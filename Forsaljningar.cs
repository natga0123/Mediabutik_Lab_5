using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    class Forsaljningar
    {
        public List<Kvitto> Alla_kvitton = new List<Kvitto>();

        public void Load_from_file(string filepath)
        {
            string delimiter = ";";
            StreamReader sr = new StreamReader(filepath);
            string alldata = sr.ReadToEnd();

            sr.Close();

            string[] rows = alldata.Split("\r".ToCharArray());
            int ii = 0;
            List<int> repeated_ids = new List<int>();

            string kvitto_id;
            string kvitto_date;
            string produkt_id;

            string produkt_s;

            string firstline = rows[0]; // skip header
            rows = rows.Where(w => w != rows[0]).ToArray();
            rows = rows.Where(w => w != "\n").ToArray();


            foreach (string r in rows)
            {
                string r1 = Regex.Replace(r, @"\t|\n\|\r|\""", "");


                string[] items = r1.Split(delimiter.ToCharArray());

                if (items.Length < 13)
                {
                    MessageBox.Show("Fel formatted fil med alla genomförda försäljningar.");
                }

                kvitto_id = items[0];
                kvitto_date = items[1];
                produkt_id = items[2];

                produkt_s = items[2] + delimiter + items[3] + delimiter + items[4] + delimiter +
                        items[5] + delimiter + items[6] + delimiter + items[7] + delimiter +
                        items[8] + delimiter + items[9] + delimiter + items[10] + delimiter +
                        items[11] + delimiter + items[12] ;

                if (ii == 0)
                {
                    this.Alla_kvitton.Add(new Kvitto());
                    this.Alla_kvitton[0].Kvitto_Id =(uint) Convert.ToUInt32(kvitto_id);
                    this.Alla_kvitton[0].Datum = DateTime.Parse(kvitto_date);

                    Produkt_list New_p_list = new Produkt_list();
                    this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor = New_p_list;
                }
                else
                {
                    int idx_kvitto = this.Alla_kvitton.FindIndex(item => item.Kvitto_Id == (uint)Convert.ToUInt32(kvitto_id));
                    if (idx_kvitto < 0) // new kvitto
                    {
                        this.Alla_kvitton.Add(new Kvitto());
                        this.Alla_kvitton[this.Alla_kvitton.Count - 1].Kvitto_Id = (uint)Convert.ToUInt32(kvitto_id);
                        this.Alla_kvitton[this.Alla_kvitton.Count - 1].Datum = DateTime.Parse(kvitto_date);

                        Produkt_list New_p_list = new Produkt_list();
                        this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor = New_p_list;
                    }

                }

                this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor.AllProdukts.Add(new Produkt());
                this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor.AllProdIDs.Add((uint)Convert.ToUInt32(produkt_id));

                int n_prod = this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor.AllProdukts.Count;

                this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor.AllProdukts[n_prod - 1].SetProductAttributesFromFile(produkt_s,delimiter);

                if (this.Alla_kvitton[this.Alla_kvitton.Count - 1].Varor.AllProdukts[n_prod - 1].ParseErrors != 0)
                {
                    MessageBox.Show("Fel i in datafilen för en såld produkt" + produkt_s);
                    return;
                }

                ii++;
            }


        }

        public void Save_to_csv(string filename)
        {
            if (filename.Trim().Length == 0)
            {
                filename = "Alla_kop_Ny_fil1.csv";
            }

            string delimiter = ";";

            string header1 = "kvitto_id;datum; prod_id; name;price;type;author;genre;format;language;platform;playtime;antal";

            string newLine = header1;
            string newLine1;

            var csv = new StringBuilder();

            csv.AppendLine(newLine);

            string kvitto_id;
            string kvitto_datum;

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

            for(var j = 0; j < this.Alla_kvitton.Count; j++)
            {
                kvitto_id = this.Alla_kvitton[j].Kvitto_Id.ToString();
                kvitto_datum = this.Alla_kvitton[j].Datum.ToString();

                newLine1 = kvitto_id + delimiter + kvitto_datum + delimiter;

                for (var i = 0; i < this.Alla_kvitton[j].Varor.AllProdukts.Count; i++)
                {
                    Name = this.Alla_kvitton[j].Varor.AllProdukts[i].Name;
                    Type_p = this.Alla_kvitton[j].Varor.AllProdukts[i].Produkt_type.ToString();
                    Antal = this.Alla_kvitton[j].Varor.AllProdukts[i].Antal.ToString();
                    Pris = this.Alla_kvitton[j].Varor.AllProdukts[i].Price.ToString();

                    Id_p = this.Alla_kvitton[j].Varor.AllProdukts[i].Id.ToString();

                    Author = this.Alla_kvitton[j].Varor.AllProdukts[i].Author;
                    Genre = this.Alla_kvitton[j].Varor.AllProdukts[i].Genre;
                    Lang = this.Alla_kvitton[j].Varor.AllProdukts[i].Language;
                    Format = this.Alla_kvitton[j].Varor.AllProdukts[i].Format;
                    Platform = this.Alla_kvitton[j].Varor.AllProdukts[i].Platform;
                    Playtime = this.Alla_kvitton[j].Varor.AllProdukts[i].Playtime.ToString();

                    switch (this.Alla_kvitton[j].Varor.AllProdukts[i].Produkt_type)
                    {
                        case Ptype.Bok:

                            newLine = newLine1 + Id_p + delimiter + Name + delimiter + Pris + delimiter +
                                Type_p + delimiter + Author + delimiter + Genre + delimiter
                                + Format + delimiter + Lang + delimiter + "" + delimiter + "" + delimiter + Antal;
                            break;
                        case Ptype.DVD:
                            newLine = newLine1 + Id_p + delimiter + Name + delimiter + Pris + delimiter +
                                Type_p + delimiter + "" + delimiter + "" + delimiter + ""
                                + delimiter + "" + delimiter + "" + delimiter + Playtime + delimiter + Antal;
                            break;
                        case Ptype.Spel:
                            newLine = newLine1 + Id_p + delimiter + Name + delimiter + Pris + delimiter +
                                Type_p + delimiter + "" + delimiter + "" + delimiter + ""
                                + delimiter + "" + delimiter + Platform + delimiter + "" + delimiter + Antal;
                            break;
                        case Ptype.Unknown:
                            newLine = newLine1 + Id_p + delimiter + Name + delimiter + Pris + delimiter +
                                Type_p + delimiter + Author + delimiter + Genre + delimiter
                                + Format + delimiter + Lang + delimiter + Platform +
                                delimiter + Playtime + delimiter + Antal;
                            break;
                        default:
                            newLine = newLine1 + Id_p + delimiter + Name + delimiter + Pris + delimiter +
                                 Type_p + delimiter + Author + delimiter + Genre + delimiter
                                 + Format + delimiter + Lang + delimiter + Platform +
                                 delimiter + Playtime + delimiter + Antal;
                            break;
                    }
                    newLine = newLine.Replace("null", "");

                    csv.AppendLine(newLine);

                }
            }


            File.WriteAllText(filename, csv.ToString(), Encoding.Unicode);
            MessageBox.Show("File " + filename + " is saved.");
        }

        public List<uint> Get_years()
        {
            List<uint> Years_tmp = new List<uint>();

            int date1;

            for (var j = 0; j < this.Alla_kvitton.Count; j++)
            {
                date1 = this.Alla_kvitton[j].Datum.Year;

                Years_tmp.Add((uint)date1);
            }

            Years_tmp = Years_tmp.Distinct().ToList();

            List<uint> Years = Years_tmp.OrderBy(o => o).ToList();

            return Years;
        }

        public List<uint> Get_month()
        {
            List<uint> Month_tmp = new List<uint>();

            int date1;

            for (var j = 0; j < this.Alla_kvitton.Count; j++)
            {
                date1 = this.Alla_kvitton[j].Datum.Month;

                Month_tmp.Add((uint)date1);
            }

            Month_tmp = Month_tmp.Distinct().ToList();

            List<uint> Month = Month_tmp.OrderBy(o => o).ToList();

            return Month;
        }

        public void Total_sale_table(DataGridView dgr, int y, int m)
        {
            if (this.Alla_kvitton.Count <= 0)
            {
                dgr.DataSource = new DataView();
                dgr.Refresh();
                return;
            }

            List<Kvitto> Valda_kvitton = new List<Kvitto>();

            if (m <= 0) // hela året 
            {
                Valda_kvitton = this.Alla_kvitton.Where(x => x.Datum.Year == y).ToList();
            }
            else
            {
                Valda_kvitton = this.Alla_kvitton.Where(x => (x.Datum.Year == y) && (x.Datum.Month == m)).ToList();
            }

            if (Valda_kvitton.Count == 0) // hittades inga försäljningar
            {
                dgr.DataSource = new DataView();
                dgr.Refresh();
                return;
            }

            dgr.DataSource = new DataView();
            //dgr.Rows.Clear();
            dgr.Refresh();

            string tablename = "Total_sale";

            DataSet dataset = new DataSet();
            dataset.Tables.Add(tablename);
            dataset.Tables[tablename].Columns.Add("Id", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Name");
            dataset.Tables[tablename].Columns.Add("Price", typeof(double));
            dataset.Tables[tablename].Columns.Add("Type");
            dataset.Tables[tablename].Columns.Add("Antal sålda", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Author");
            dataset.Tables[tablename].Columns.Add("Genre");
            dataset.Tables[tablename].Columns.Add("Format");
            dataset.Tables[tablename].Columns.Add("Language");
            dataset.Tables[tablename].Columns.Add("Plattform");
            dataset.Tables[tablename].Columns.Add("Playtime", typeof(uint));

            int ii;
            ii = 0;

            List<uint> Products_val_ids = new List<uint>();
            List<Produkt> Products_val = new List<Produkt>();

            List<Produkt> Products_val_uniq = new List<Produkt>();
            
            foreach(Kvitto k in Valda_kvitton)
            {
                Products_val.AddRange(Valda_kvitton[ii].Varor.AllProdukts);
                Products_val_ids.AddRange(Valda_kvitton[ii].Varor.AllProdIDs);
                ii++;
            }

            Products_val_ids = Products_val_ids.Distinct().ToList();

            uint[] Products_antal_tot = new uint[Products_val_ids.Count];

            ii = 0;

            foreach (var k in Products_val_ids)
            {
                int jj = Products_val.FindIndex(x => x.Id == k);

                Products_val_uniq.Add(Products_val[jj]);  
            }

            foreach (Produkt t in Products_val)
            {
                int jj = Products_val_uniq.FindIndex(x => x.Id == t.Id);
                Products_antal_tot[jj] += t.Antal;
            }

            foreach (Produkt p in Products_val_uniq)
            {

                dataset.Tables[tablename].Rows.Add(p.Id.ToString(),
                    p.Name, p.Price.ToString(),
                    p.Produkt_type.ToString(), Products_antal_tot[ii].ToString(),
                    p.Author.ToString(),
                    p.Genre.ToString(), p.Format.ToString(),
                    p.Language.ToString(), p.Platform.ToString(),
                    p.Playtime.ToString());
                ii++;
            }

            dgr.DataSource = dataset.Tables[0].DefaultView;

            //Main_table1 = dataset.Tables[0];

            foreach (DataGridViewColumn column in dgr.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }
        public void Top10_table(DataGridView dgr, int y, int m)
        {

            if (this.Alla_kvitton.Count <= 0)
            {
                dgr.DataSource = new DataView();
                dgr.Refresh();
                return;
            }

            List<Kvitto> Valda_kvitton = new List<Kvitto>();

            if (m <= 0) // hela året 
            {
                Valda_kvitton = this.Alla_kvitton.Where(x => x.Datum.Year == y).ToList();
            }
            else
            {
                Valda_kvitton = this.Alla_kvitton.Where(x => (x.Datum.Year == y) && (x.Datum.Month == m)).ToList();
            }

            if (Valda_kvitton.Count == 0) // hittades inga försäljningar
            {
                dgr.DataSource = new DataView();
                dgr.Refresh();
                return;
            }

            dgr.DataSource = new DataView();
            //dgr.Rows.Clear();
            dgr.Refresh();

            string tablename = "Top_10";

            DataSet dataset = new DataSet();
            dataset.Tables.Add(tablename);
            dataset.Tables[tablename].Columns.Add("Id", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Name");
            dataset.Tables[tablename].Columns.Add("Price", typeof(double));
            dataset.Tables[tablename].Columns.Add("Type");
            dataset.Tables[tablename].Columns.Add("Antal sålda", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Author");
            dataset.Tables[tablename].Columns.Add("Genre");
            dataset.Tables[tablename].Columns.Add("Format");
            dataset.Tables[tablename].Columns.Add("Language");
            dataset.Tables[tablename].Columns.Add("Plattform");
            dataset.Tables[tablename].Columns.Add("Playtime", typeof(uint));

            DataSet dataset1 = new DataSet();
            dataset1.Tables.Add(tablename);
            dataset1.Tables[tablename].Columns.Add("Id", typeof(uint));
            dataset1.Tables[tablename].Columns.Add("Name");
            dataset1.Tables[tablename].Columns.Add("Price", typeof(double));
            dataset1.Tables[tablename].Columns.Add("Type");
            dataset1.Tables[tablename].Columns.Add("Antal sålda", typeof(uint));
            dataset1.Tables[tablename].Columns.Add("Author");
            dataset1.Tables[tablename].Columns.Add("Genre");
            dataset1.Tables[tablename].Columns.Add("Format");
            dataset1.Tables[tablename].Columns.Add("Language");
            dataset1.Tables[tablename].Columns.Add("Plattform");
            dataset1.Tables[tablename].Columns.Add("Playtime", typeof(uint));

            int ii;
            ii = 0;

            List<uint> Products_val_ids = new List<uint>();
            List<Produkt> Products_val = new List<Produkt>();

            List<Produkt> Products_val_uniq = new List<Produkt>();

            foreach (Kvitto k in Valda_kvitton)
            {
                Products_val.AddRange(Valda_kvitton[ii].Varor.AllProdukts);
                Products_val_ids.AddRange(Valda_kvitton[ii].Varor.AllProdIDs);
                ii++;
            }

            Products_val_ids = Products_val_ids.Distinct().ToList();

            uint[] Products_antal_tot = new uint[Products_val_ids.Count];
            int[] Products_antal_tmp = new int[Products_val_ids.Count];

            ii = 0;

            foreach (var k in Products_val_ids)
            {
                int jj = Products_val.FindIndex(x => x.Id == k);

                Products_val_uniq.Add(Products_val[jj]);
            }

            foreach (Produkt t in Products_val)
            {
                int jj = Products_val_uniq.FindIndex(x => x.Id == t.Id);
                Products_antal_tot[jj] += t.Antal;
                Products_antal_tmp[jj] += (int)t.Antal;
            }

            Array.Sort<int>(Products_antal_tmp);
            Array.Reverse(Products_antal_tmp);

            int cut_off;

            if (Products_antal_tmp.Length > 10)
            {
                cut_off = Products_antal_tmp[9];
            }
            else
            {
                cut_off = Products_antal_tmp[Products_antal_tmp.Length -1];
            }

            int i1 = 0;

            ii = 0;

            foreach (Produkt p in Products_val_uniq)
            {
                if (Products_antal_tot[ii] > 0)
                {
                    dataset.Tables[tablename].Rows.Add(p.Id.ToString(),
                    p.Name, p.Price.ToString(),
                    p.Produkt_type.ToString(), Products_antal_tot[ii].ToString(),
                    p.Author.ToString(),
                    p.Genre.ToString(), p.Format.ToString(),
                    p.Language.ToString(), p.Platform.ToString(),
                    p.Playtime.ToString());
                    i1++;
                }
                
                ii++;
            }

            dataset.Tables[0].DefaultView.Sort = "Antal sålda DESC";

            var records = dataset.Tables[0].AsEnumerable().OrderByDescending(v => v["Antal sålda"]).Take(10);
            foreach (DataRow r in records)
            {
                dataset1.Tables[0].Rows.Add(r.ItemArray);
            }


            dataset1.Tables[0].DefaultView.Sort = "Antal sålda DESC";

            dgr.DataSource = dataset1.Tables[0];

            

            //Main_table1 = dataset.Tables[0];

            foreach (DataGridViewColumn column in dgr.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


        }

    }
}
