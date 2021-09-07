using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    public enum Ptype
    {
        Bok,
        DVD,
        Spel,
        Unknown
    };
    class Produkt
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Ptype Produkt_type { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public string Platform { get; set; }
        public uint Playtime { get; set; }
        public uint Antal { get; set; }
        public int ParseErrors { get; set; }

        public Produkt()
        {


        }

        public void SetProductAttributesFromFile(string s, string delimiter)
        {
            int result;
            double price;
            int playtime;
            int antal;
            Ptype prodtype;
            prodtype = Ptype.Unknown;

            string[] items = s.Split(delimiter.ToCharArray());
            if (items.Length >= 11)
            {
                try
                {
                    if (items[0].Equals("\n")){
                        result = 0;
                    }
                    else {
                        result = Int32.Parse(items[0]); // Id
                        if (result < 0)
                        {
                            MessageBox.Show("Found product Id < 0.");
                            ParseErrors = 1;
                            return;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    ParseErrors = 1;
                    return;
                }
                if (items[2].Length > 0) // Price
                {
                    try
                    {
                        price = Double.Parse(items[2]);
                        if (price < 0)
                        {
                            MessageBox.Show("Found product Price < 0.");
                            ParseErrors = 1;
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                        ParseErrors = 1;
                        return;
                    }
                }
                else
                {
                    price = 0;
                }

                items[3] = items[3].Trim(); // Type

                if (items[3].Length > 0)
                {
                    if (String.Equals(items[3], Ptype.Bok.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        prodtype = Ptype.Bok;
                    }
                    else if (String.Equals(items[3], Ptype.DVD.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        prodtype = Ptype.DVD;
                    }
                    else if (String.Equals(items[3], Ptype.Spel.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        prodtype = Ptype.Spel;
                    }
                    else if (String.Equals(items[3], Ptype.Unknown.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        prodtype = Ptype.Unknown;
                    }
                }
                else
                {
                    prodtype = Ptype.Unknown;
                }

                if (items[9].Length > 0) // Playtime
                {
                    try
                    {
                        playtime = Int32.Parse(items[9]);
                        if (playtime < 0)
                        {
                            MessageBox.Show("Found product Playtime < 0.");
                            ParseErrors = 1;
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                        ParseErrors = 1;
                        return;
                    }
                }
                else
                {
                    playtime = 0;
                }
                if (items[10].Length > 0)
                {
                    try
                    {
                        antal = Int32.Parse(items[10]);
                        if (antal < 0)
                        {
                            MessageBox.Show("Found product antal < 0.");
                            ParseErrors = 1;
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                        ParseErrors = 1;
                        return;
                    }
                }
                else
                {
                    antal = 0;
                }

                this.Id = (uint)result;
                this.Name = items[1];
                this.Price = price;
                this.Produkt_type = prodtype;
                this.Author = items[4];
                this.Genre = items[5];
                this.Format = items[6];
                this.Language = items[7];
                this.Platform = items[8];
                this.Playtime = (uint)playtime;
                this.Antal = (uint)antal;

                this.Set_extra_attributes(this.Produkt_type, this.Author, this.Genre,
                    this.Format, this.Platform, this.Language, this.Playtime);

            }
            else
            {
                MessageBox.Show("Number of fields in datafile row is less than 11");
                ParseErrors = 1;
                return;
            }
        }

        public void Set_extra_attributes(Ptype Produkt_type,
            string Author, string Genre, string Format,
            string Platform, string Language, uint Playtime)
        {
            switch (Produkt_type)
            {
                case Ptype.Bok:
                    this.Author = Author;
                    this.Genre = Genre;
                    this.Format = Format;
                    this.Language = Language;
                    this.Platform = "";
                    this.Playtime = 0;
                    break;
                case Ptype.DVD:
                    this.Author = "";
                    this.Genre = "";
                    this.Format = "";
                    this.Language = "";
                    this.Platform = "";
                    this.Playtime = Playtime;
                    break;
                case Ptype.Spel:
                    this.Author = "";
                    this.Genre = "";
                    this.Format = "";
                    this.Language = "";
                    this.Platform = Platform;
                    this.Playtime = 0;
                    break;
                case Ptype.Unknown:
                    this.Author = Author;
                    this.Genre = Genre;
                    this.Format = Format;
                    this.Language = Language;
                    this.Platform = Platform;
                    this.Playtime = Playtime;
                    break;
                default:
                    this.Author = "";
                    this.Genre = "";
                    this.Format = "";
                    this.Language = "";
                    this.Platform = "";
                    this.Playtime = 0;
                    break;
            }
        }

    }
}

