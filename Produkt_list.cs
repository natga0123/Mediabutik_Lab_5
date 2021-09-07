using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    class Produkt_list
    {
        public string Filename="";
        public string Produkt_list_name;
        
        public List<uint> AllProdIDs = new List<uint>();
        public List<Produkt> AllProdukts = new List<Produkt>();
        public uint Errors;
        public uint Last_Deleted_Prod_Id;

        public Produkt_list(string Produkt_list_name="")
        {
            this.Errors = 0;
            this.Produkt_list_name = Produkt_list_name;
            
        }

        public void Read_produkt_file(string Filename)
        {
            if (!File.Exists(Filename))
            {
                MessageBox.Show("Varulista varor_1.csv hittades inte. ");
                return;
            }

            string delimiter = ";";
            StreamReader sr = new StreamReader(Filename);

            string alldata = sr.ReadToEnd();

            sr.Close();

            string[] rows = alldata.Split("\r".ToCharArray());
            int ii = 0;
            List<int> repeated_ids = new List<int>();
            int jj = 0;

            string firstline = rows[0]; // skip header
            rows = rows.Where(w => w != rows[0]).ToArray();
            rows = rows.Where(w => w != "\n").ToArray();

            foreach (string r in rows)
            {
                AllProdukts.Add(new Produkt());

                string  r1 = System.Text.RegularExpressions.Regex.Replace(r, @"\t|\n|\r|", "");

                r1 = r1.Replace("\"", "");


                AllProdukts[ii].SetProductAttributesFromFile(r1, delimiter);

                if (AllProdukts[ii].ParseErrors != 0)
                {
                    Errors = 1;
                    return;
                }

                if (AllProdIDs.Contains(AllProdukts[ii].Id))
                {
                    AllProdIDs.Add(0);
                    repeated_ids.Add(ii);
                    jj++;
                }
                else
                {
                    AllProdIDs.Add(AllProdukts[ii].Id);
                }

                ii++;
            }

            if(repeated_ids.Count > 0) // fix id in case of repeated ids in the initial file
            {
                uint[] int_ids = AllProdIDs.ToArray();
                uint max_id = int_ids.Max();
                uint jjj = 0;

                foreach (uint iii in repeated_ids)
                {
                    jjj++;
                    AllProdIDs[(int)iii] = max_id + jjj;
                    AllProdukts[(int)iii].Id = max_id + jjj;
                }
            }

        }
        public void Add_existing_product(uint ProdId, uint increase)
        {
            if (AllProdIDs.Contains(ProdId))
            {
                int ii = AllProdukts.FindIndex(x => x.Id == (int)ProdId);
                if (ii >= 0)
                {
                    AllProdukts[ii].Antal += increase;
                } 
            }
            else
            {
                MessageBox.Show("Required Product Id not found.");
            }
        }
        public void Remove_existing_product(uint ProdId, uint decrease)
        {
            if (AllProdIDs.Contains(ProdId))
            {
                int ii = AllProdukts.FindIndex(x => x.Id == (int)ProdId);

                if (ii >= 0)
                {
                    if (AllProdukts[ii].Antal >= decrease)
                        AllProdukts[ii].Antal -= decrease;
                    else
                    {
                        MessageBox.Show("Cannot remove more products than the number of all available.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Required Product Id not found.");
            }
        }
        public void Add_new_product(Produkt Prod)
        {
            uint[] int_ids = AllProdIDs.ToArray();
            uint max_id;

            if (int_ids.Length == 0) // lägger till första produkten
            {
                max_id = 0;
                AllProdukts.Add(Prod);
                AllProdukts[AllProdukts.Count - 1].Id = 0;
                AllProdIDs.Add(0);
            }
            else
            {
                uint new_id;
                max_id = int_ids.Max();

                if (max_id > Last_Deleted_Prod_Id)
                {
                    new_id = max_id + 1;
                }
                else
                {
                    new_id = Last_Deleted_Prod_Id + 1;
                }

                AllProdukts.Add(Prod);
                AllProdukts[AllProdukts.Count - 1].Id = new_id;
                AllProdIDs.Add(new_id);
            } 

        }
        //public void Return_product(uint ProdId, uint increase)
        //{
        //    Add_existing_product(ProdId, increase);
        //}
        public void Remove_product(uint ProdId)
        {
            if (AllProdIDs.Contains(ProdId))
            {
                Last_Deleted_Prod_Id = ProdId;
                AllProdukts.RemoveAll(x => x.Id == ProdId);
                AllProdIDs.RemoveAll(x => x == ProdId);
            }
            else
            {
                MessageBox.Show("Required Product Id not found.");
            }
        }

        public void Save_products_to_csv(string filename)
        {
            if (filename.Trim().Length == 0)
            {
                filename = "varor_1.csv";
            }

            string delimiter = ";";

            string header1 = "id;name;price;type;author;genre;format;language;platform;playtime;antal";

            string newLine = header1;

            var csv = new StringBuilder();

            csv.AppendLine(newLine);

            string nr;
            string Name;
            string Antal;
            string Pris;
            string Author;
            string Type_p;
            string Format;
            string Genre;
            string Playtime;
            string Platform;
            string Id_p;
            string Lang;

            for (var i = 0; i < this.AllProdukts.Count; i++)
            {
                nr = (i + 1).ToString();
                Name = this.AllProdukts[i].Name;
                Type_p = this.AllProdukts[i].Produkt_type.ToString();
                Antal = this.AllProdukts[i].Antal.ToString();
                Pris = this.AllProdukts[i].Price.ToString();

                Id_p = this.AllProdukts[i].Id.ToString();

                Author = this.AllProdukts[i].Author;
                Genre = this.AllProdukts[i].Genre;
                Lang = this.AllProdukts[i].Language;
                Format = this.AllProdukts[i].Format;
                Platform = this.AllProdukts[i].Platform;
                Playtime = this.AllProdukts[i].Playtime.ToString();

                if (Author == null)
                {
                    Author = "";
                }
                if (Genre == null)
                {
                    Genre = "";
                }
                if (Lang == null)
                {
                    Lang = "";
                }
                if (Format == null)
                {
                    Format = "";
                }
                if (Platform == null)
                {
                    Platform = "";
                }
                if(Playtime == null)
                {
                    Playtime = "";
                }

                switch (this.AllProdukts[i].Produkt_type)
                {
                    case Ptype.Bok:

                        newLine = Id_p + delimiter + Name + delimiter + Pris + delimiter +
                            Type_p + delimiter + Author + delimiter + Genre + delimiter
                            + Format + delimiter + Lang + delimiter + "" + delimiter + "" + delimiter + Antal;
                        break;
                    case Ptype.DVD:
                        newLine = Id_p + delimiter + Name + delimiter + Pris + delimiter +
                            Type_p + delimiter + "" +  delimiter + "" + delimiter + ""
                            + delimiter + "" + delimiter + "" + delimiter + Playtime + delimiter + Antal;
                        break;
                    case Ptype.Spel:
                        newLine = Id_p + delimiter + Name + delimiter + Pris + delimiter +
                            Type_p + delimiter + "" + delimiter + "" + delimiter + ""
                            + delimiter + "" + delimiter + Platform +  delimiter + "" + delimiter + Antal;
                        break;
                    case Ptype.Unknown:
                        newLine = Id_p + delimiter + Name + delimiter + Pris + delimiter +
                            Type_p + delimiter + Author + delimiter + Genre + delimiter
                            + Format + delimiter + Lang + delimiter+ Platform +
                            delimiter + Playtime + delimiter + Antal;
                        break;
                    default:
                        newLine = Id_p + delimiter + Name + delimiter + Pris + delimiter +
                             Type_p + delimiter + Author + delimiter + Genre + delimiter
                             + Format + delimiter + Lang + delimiter + Platform +
                             delimiter + Playtime + delimiter + Antal;
                        break;
                }
                newLine = newLine.Replace("null", "");

                csv.AppendLine(newLine);
            }

            File.WriteAllText(filename, csv.ToString(), Encoding.Unicode);
            MessageBox.Show("File "+ filename+" is saved.");

        }


        public Produkt_list Copy()
        {
            Produkt_list New_list = new Produkt_list();

            New_list.Filename = String.Copy(this.Filename);
            New_list.Produkt_list_name = String.Copy(this.Produkt_list_name);
            New_list.Errors = this.Errors;

            New_list.AllProdIDs = new List<uint>();
            New_list.AllProdukts = new List<Produkt>();

            uint id_tmp, antal_tmp;
            double pris_tmp;

            if (this.AllProdIDs.Count > 0)
            {
                for (var i = 0; i < this.AllProdIDs.Count; i++)
                {
                    Produkt Prod_tmp = new Produkt();

                    id_tmp = this.AllProdIDs[i];
                    antal_tmp = this.AllProdukts[i].Antal;
                    pris_tmp = this.AllProdukts[i].Price;

                    New_list.AllProdIDs.Add(id_tmp);
                    New_list.AllProdukts.Add(Prod_tmp);

                    New_list.AllProdukts[i].Id = id_tmp;
                    New_list.AllProdukts[i].Antal = antal_tmp;
                    New_list.AllProdukts[i].Price = pris_tmp;

                    New_list.AllProdukts[i].Author = String.Copy(this.AllProdukts[i].Author);
                    New_list.AllProdukts[i].Format = String.Copy(this.AllProdukts[i].Format);
                    New_list.AllProdukts[i].Genre = String.Copy(this.AllProdukts[i].Genre);
                    New_list.AllProdukts[i].Language = String.Copy(this.AllProdukts[i].Language);
                    New_list.AllProdukts[i].Name = String.Copy(this.AllProdukts[i].Name);
                    New_list.AllProdukts[i].ParseErrors = this.AllProdukts[i].ParseErrors;
                    New_list.AllProdukts[i].Platform = String.Copy(this.AllProdukts[i].Platform);
                    New_list.AllProdukts[i].Playtime = this.AllProdukts[i].Playtime;
                    New_list.AllProdukts[i].Produkt_type = this.AllProdukts[i].Produkt_type;

                }
            }


            return New_list;
        }

        public void Subtract(Produkt_list Nykopta_varor)
        {
            if (this.AllProdIDs.Count > 0 & Nykopta_varor.AllProdIDs.Count > 0)
            {
                uint antal_tmp, prod_id_tmp;
                int idx;
                this.Errors = 0;

                for (var i = 0; i < Nykopta_varor.AllProdIDs.Count; i++)
                {
                    antal_tmp = Nykopta_varor.AllProdukts[i].Antal;
                    prod_id_tmp = Nykopta_varor.AllProdukts[i].Id;

                    idx = this.AllProdukts.FindIndex(item => item.Id == prod_id_tmp);

                    if (this.AllProdukts[idx].Antal >= antal_tmp)
                    {
                        this.AllProdukts[idx].Antal = this.AllProdukts[idx].Antal - antal_tmp;
                    }
                    else
                    {
                        this.Errors = 1;
                        MessageBox.Show("Antalet tillgängliga produkter har överskridits.");
                        return;
                    }


                }

            }
        }


        public void Update_Produkt_list_from_XML(string XML_file, Produkt_list Produkt_list_innan_exp)
        {
            if (!File.Exists(XML_file))
            {
                MessageBox.Show("XML fil med sökvägen "+XML_file + " hittades inte.");
                return;
            }

            string[] Lines = File.ReadAllLines(XML_file);

            if (Lines.Length < 14)
            {
                MessageBox.Show("XML fil är tom eller ofullständig, antal rader mindre än 14.");
                return;
            }

            Lines = Lines.Skip(1).ToArray();
            Lines = Lines.Skip(1).ToArray();

            Array.Resize(ref Lines, Lines.Length - 1);

            int i = 0;
            int N_Lines = Lines.Length;
            int ind1;
            string Str, Str1;
            string S_name="", S_count="", S_price="", S_comment = "", 
                S_artist="", S_publisher = "", S_genre="", S_year="", S_Id="";
            int k = 0;

            for (int j = 0; j < N_Lines; j++)
            {
                Str = Lines[j].Trim();
                k = 0;
                while (k < 50)
                {

                    Str1 = Lines[j+k].Trim();

                    if (Str1.Contains("</Item>"))
                    {
                        j = j + k;
                        k = 100;
                    }
                    else if (Str1.Contains( "<Item>"))
                    {
                        i++;
                    }
                    else if (Str1.Contains("<Name>"))
                    {
                        ind1 = Str1.IndexOf("<", 6);
                        S_name = Str1.Substring(6, ind1-6);
                    }
                    else if (Str1.Contains("<Count>"))
                    {
                        ind1 = Str1.IndexOf("<", 7);
                        S_count = Str1.Substring(7, ind1-7);
                    }
                    else if (Str1.Contains("<Price>"))
                    {
                        ind1 = Str1.IndexOf("<", 7);
                        S_price = Str1.Substring(7, ind1-7);
                    }
                    else if (Str1.Contains("<Comment>"))
                    {
                        ind1 = Str1.IndexOf("<", 9);
                        if (ind1 > 0)
                        {
                            S_comment = Str1.Substring(9, ind1 - 9);
                        }
                        else
                        {
                            S_comment = "";
                        }

                    }
                    else if (Str1.Contains("<Artist>"))
                    {
                        ind1 = Str1.IndexOf("<", 8);
                        if (ind1 > 0)
                        {
                            S_artist = Str1.Substring(8, ind1 - 8);
                        }
                        else
                        {
                            S_artist = "";
                        }
                            
                    }
                    else if (Str1.Contains("<Publisher>"))
                    {
                        ind1 = Str1.IndexOf("<", 11);
                        if (ind1 > 0)
                        {
                            S_publisher = Str1.Substring(11, ind1 - 11);
                        }
                        else
                        {
                            S_publisher = "";
                        }
                        
                    }
                    else if (Str1.Contains("<Genre>"))
                    {
                        ind1 = Str1.IndexOf("<", 7);
                        if (ind1 > 0)
                        {
                            S_genre = Str1.Substring(7, ind1 - 7);
                        }
                        else
                        {
                            S_genre = "";
                        }
                    }
                    else if (Str1.Contains("<Year>"))
                    {
                        ind1 = Str1.IndexOf("<", 6);
                        if (ind1 > 0)
                        {
                            S_year = Str1.Substring(6, ind1 - 6);
                        }
                        else
                        {
                            S_year = "";
                        }
                    }
                    else if (Str1.Contains("<ProductID>"))
                    {
                        ind1 = Str1.IndexOf("<", 11);
                        if (ind1 - 11 > 0)
                        {
                            S_Id = Str1.Substring(11, ind1 - 11);
                        }
                        else
                        {
                            MessageBox.Show("ProduktID rad är tom.");
                            return;
                        }
                    }

                    k++;

                }

                if (S_Id.Length == 0)
                {
                    MessageBox.Show("Produkt Id fält är tomt");
                    return;
                }

                
                uint idu = (uint)Convert.ToUInt32(S_Id);
                uint antal_u = (uint)Convert.ToUInt32(S_count);
                S_price = S_price.Replace(".", ",");
                double price_u = Convert.ToDouble(S_price);

                if (price_u < 0)
                {
                    MessageBox.Show("Hittat pris < 0 ");
                    return;
                }

                int idx = this.AllProdukts.FindIndex(item => item.Id == idu);

                if (idx >= 0) // Det är en existerande produkt
                {
                    if (Produkt_list_innan_exp.AllProdukts.Count() > 0)
                    {
                        int idx1 = Produkt_list_innan_exp.AllProdukts.FindIndex(item => item.Id == idu);
                        if (idx1 >= 0) {
                            int delta_antal = (int)antal_u - (int)Produkt_list_innan_exp.AllProdukts[idx1].Antal;
                            int Antal_tmp = (int)this.AllProdukts[idx].Antal + delta_antal;
                            this.AllProdukts[idx].Antal = (uint)Antal_tmp;
                        }
                        else
                        {
                            //MessageBox.Show("Produkt ID from import is not found in produkt innan import listan");
                        }
                    }
                    else
                    {
                        this.AllProdukts[idx].Antal = antal_u;
                    }
                    
                }
                else // ny produkt
                {
                    Produkt Prod1 = new Produkt();

                    Prod1.Id = idu;
                    Prod1.Antal = antal_u;
                    Prod1.Price = price_u;
                    Prod1.Name = S_name;
                    Prod1.Author = S_artist;
                    Prod1.Genre = S_genre;
                    Prod1.Produkt_type = Ptype.Unknown;
                    Prod1.Set_extra_attributes(Ptype.Unknown, S_artist, S_genre, "", "", "", 0);

                    this.Add_new_product(Prod1);
                    this.AllProdukts[this.AllProdukts.Count-1].Id = idu;
                    this.AllProdIDs[this.AllProdukts.Count-1] = idu;

                }

            }

        }
    }
        
}
