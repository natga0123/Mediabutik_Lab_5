using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    class Controller_1
    {
        public DataTable Main_table0;
        public DataTable Table_stat0;
        
        public Produkt_list Varukorg;

        public Produkt_list Retur_korg;

        public Produkt_list Produkt_list_1;

        public Forsaljningar Kvitto_list;

        public enum Monader
        {
            Januari = 1,
            Februari,
            Mars,
            April,
            Maj,
            Juni,
            Juli,
            Augusti,
            September,
            Oktober,
            November,
            December
        };

        public Controller_1()
        {

            Produkt_list_1 = new Produkt_list("All_products_list");
            Varukorg = new Produkt_list("Varukorg");
            Retur_korg = new Produkt_list("Retur_korg");
            Kvitto_list = new Forsaljningar();

        }
        public void Loaddata_control(DataGridView dgr, Produkt_list Produkt_list0)
        {
            string tablename = "varor";


            DataSet dataset = new DataSet();
            dataset.Tables.Add(tablename);
            dataset.Tables[tablename].Columns.Add("Id", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Name");
            dataset.Tables[tablename].Columns.Add("Price", typeof(double));
            dataset.Tables[tablename].Columns.Add("Type");
            dataset.Tables[tablename].Columns.Add("Antal", typeof(uint));
            dataset.Tables[tablename].Columns.Add("Author");
            dataset.Tables[tablename].Columns.Add("Genre");
            dataset.Tables[tablename].Columns.Add("Format");
            dataset.Tables[tablename].Columns.Add("Language");
            dataset.Tables[tablename].Columns.Add("Plattform");
            dataset.Tables[tablename].Columns.Add("Playtime", typeof(uint));
            //dataset.Tables[tablename].Columns.Add("Antal", typeof(uint));

            int ii;
            ii = 0;
            //string playtime_s;

            foreach (Produkt p in Produkt_list0.AllProdukts)
            {

                dataset.Tables[tablename].Rows.Add(Produkt_list0.AllProdukts[ii].Id.ToString(),
                    Produkt_list0.AllProdukts[ii].Name, Produkt_list0.AllProdukts[ii].Price.ToString(),
                    Produkt_list0.AllProdukts[ii].Produkt_type.ToString(), Produkt_list0.AllProdukts[ii].Antal.ToString(),
                    Produkt_list0.AllProdukts[ii].Author.ToString(),
                    Produkt_list0.AllProdukts[ii].Genre.ToString(), Produkt_list0.AllProdukts[ii].Format.ToString(),
                    Produkt_list0.AllProdukts[ii].Language.ToString(), Produkt_list0.AllProdukts[ii].Platform.ToString(),
                    Produkt_list0.AllProdukts[ii].Playtime.ToString());
                ii++;
            }

            dgr.DataSource = dataset.Tables[0].DefaultView;

            Main_table0 = dataset.Tables[0];

            foreach (DataGridViewColumn column in dgr.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        public void Sortdata_control(string argument, string Text, string Name_text, string Type_text, DataGridView dgr)
        {
            int field;

            if (String.Compare(argument, "Name") == 0)
            {
                field = 1;
            }
            else if (String.Compare(argument, "Type") == 0)
            {
                field = 3;
            }
            else
            {
                return;
            }

            try
            {

                var test = dgr.DataSource;
                if (field == 1)
                {
                    if (Type_text.Length == 0)
                    {
                        if (Name_text.Length == 0)
                        {
                            dgr.DataSource = null;
                            Main_table0.DefaultView.RowFilter = null;
                            dgr.DataSource = Main_table0.DefaultView;
                        }
                        else
                        {
                            dgr.DataSource = null;
                            Main_table0.DefaultView.RowFilter = null;
                            Main_table0.DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", Text);
                            dgr.Rows.Clear();
                            dgr.DataSource = Main_table0.DefaultView;
                            int test1 = dgr.Rows.Count;
                        }
                    }
                    else
                    {
                        dgr.DataSource = null;
                        Main_table0.DefaultView.RowFilter = null;
                        //Main_table1.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%' AND Type LIKE '%{1}%'", Name_text, Type_text);
                        Main_table0.DefaultView.RowFilter = string.Format("Name LIKE '" + Name_text + "*' AND Type LIKE '" + Type_text + "*'");

                        dgr.Rows.Clear();
                        dgr.DataSource = Main_table0.DefaultView;
                        int test1 = dgr.Rows.Count;
                    }
                }
                if (field == 3)
                {
                    if (Name_text.Length == 0)
                    {
                        if (Type_text.Length == 0)
                        {
                            dgr.DataSource = null;
                            Main_table0.DefaultView.RowFilter = null;
                            dgr.DataSource = Main_table0.DefaultView;
                        }
                        else
                        {
                            dgr.DataSource = null;
                            Main_table0.DefaultView.RowFilter = null;
                            Main_table0.DefaultView.RowFilter = string.Format("Type LIKE '{0}%'", Text);
                            dgr.Rows.Clear();
                            dgr.DataSource = Main_table0.DefaultView;
                            int test1 = dgr.Rows.Count;
                        }
                    }
                    else
                    {
                        dgr.DataSource = null;
                        Main_table0.DefaultView.RowFilter = null;
                        //Main_table1.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%' AND Type LIKE '%{1}%'", Name_text, Type_text);
                        Main_table0.DefaultView.RowFilter = string.Format("Name LIKE '" + Name_text + "*' AND Type LIKE '" + Type_text + "*'");
                        dgr.Rows.Clear();
                        dgr.DataSource = Main_table0.DefaultView;
                        int test1 = dgr.Rows.Count;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void Load_statistics_control(DataGridView dgr_top10, DataGridView dgr_all,
            ComboBox combo_year_top10, ComboBox combo_month_top10,
            ComboBox combo_year_all, ComboBox combo_month_all, Forsaljningar Kvitto_list)
        {
            dgr_top10.DataSource = new DataView();
            dgr_top10.Refresh();

            dgr_all.DataSource = new DataView();
            dgr_all.Refresh();

            combo_year_top10.SelectedIndex = -1;
            combo_year_all.SelectedIndex = -1;

            combo_month_top10.SelectedIndex = -1;
            combo_month_all.SelectedIndex = -1;

            if (Kvitto_list.Alla_kvitton == null)
            {
                return;
            }
            if (Kvitto_list.Alla_kvitton.Count == 0)
            {
                return;
            }

            List<uint> Years = new List<uint>();

            Years = Kvitto_list.Get_years();

            combo_year_top10.Items.Clear();
            combo_year_all.Items.Clear();

            foreach (var y in Years)
            {
                combo_year_top10.Items.Add(y.ToString());
                combo_year_all.Items.Add(y.ToString());
            }

            List<uint> Month = new List<uint>();

            Month = Kvitto_list.Get_month();

            combo_month_top10.Items.Clear();
            combo_month_all.Items.Clear();

            foreach (var m in Month)
            {
                var m_tmp = (Monader)m;
                combo_month_top10.Items.Add(m_tmp.ToString());
                combo_month_all.Items.Add(m_tmp.ToString());
            }

            Table_stat0 = new DataTable();

        }

        public void Controller_top10_click(ComboBox combo_year_top10, ComboBox combo_month_top10,
            Forsaljningar Kvitto_list, DataGridView dgr_top10)
        {
            int Year = Convert.ToInt32(combo_year_top10.SelectedItem.ToString().Trim());
            int Month;

            if (combo_month_top10.SelectedItem == null)
            {
                Month = -1;
            }
            else
            {
                string Month_s = combo_month_top10.SelectedItem.ToString().Trim();

                if (Month_s.Equals("Januari", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 1;
                }
                else if (Month_s.Equals("Februari", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 2;
                }
                else if (Month_s.Equals("Mars", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 3;
                }
                else if (Month_s.Equals("April", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 4;
                }
                else if (Month_s.Equals("Maj", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 5;
                }
                else if (Month_s.Equals("Juni", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 6;
                }
                else if (Month_s.Equals("Juli", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 7;
                }
                else if (Month_s.Equals("Augusti", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 8;
                }
                else if (Month_s.Equals("September", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 9;
                }
                else if (Month_s.Equals("Oktober", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 10;
                }
                else if (Month_s.Equals("November", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 11;
                }
                else if (Month_s.Equals("December", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 12;
                }
                else
                {
                    MessageBox.Show("Månad value är inte identidfierad.");
                    return;
                }
            }


            if (Year <= 0)
            {
                MessageBox.Show("År måste anges");
                return;
            }

            Kvitto_list.Top10_table(dgr_top10, Year, Month);
        }

        public void Controller_total_click(ComboBox combo_year_all, ComboBox combo_month_all,
            Forsaljningar Kvitto_list, DataGridView dgr_all)
        {
            int Year = Convert.ToInt32(combo_year_all.SelectedItem.ToString().Trim());

            int Month;

            if (combo_month_all.SelectedItem == null)
            {
                Month = -1;
            }
            else
            {
                string Month_s = combo_month_all.SelectedItem.ToString().Trim();

                if (Month_s.Equals("Januari", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 1;
                }
                else if (Month_s.Equals("Februari", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 2;
                }
                else if (Month_s.Equals("Mars", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 3;
                }
                else if (Month_s.Equals("April", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 4;
                }
                else if (Month_s.Equals("Maj", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 5;
                }
                else if (Month_s.Equals("Juni", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 6;
                }
                else if (Month_s.Equals("Juli", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 7;
                }
                else if (Month_s.Equals("Augusti", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 8;
                }
                else if (Month_s.Equals("September", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 9;
                }
                else if (Month_s.Equals("Oktober", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 10;
                }
                else if (Month_s.Equals("November", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 11;
                }
                else if (Month_s.Equals("December", StringComparison.OrdinalIgnoreCase))
                {
                    Month = 12;
                }
                else
                {
                    MessageBox.Show("Månad value är inte identidfierad.");
                    return;
                }
            }

            if (Year <= 0)
            {
                MessageBox.Show("År måste anges");
                return;
            }

            Kvitto_list.Total_sale_table(dgr_all, Year, Month);
        }

        public void Btn_Retur_Click(DataGridView Dgr_retur, DataGridView Dgr_kassa_varor,
            TextBox Textbox_kvitto_nr, Forsaljningar Kvitto_list)
        {
            if (Dgr_retur == null || Dgr_retur.Rows.Count == 0)
            {
                MessageBox.Show("Finns inga varor i returkorgen.");
                return;
            }
            int ind1 = 0;

            foreach (DataGridViewRow row in Dgr_retur.SelectedRows)
            {
                ind1 = row.Index;
            }

            string ids = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Id"].Value);
            uint idu = (uint)Convert.ToUInt32(ids);

            string antal_s = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Antal"].Value);
            int antal_u = (int)Convert.ToInt32(antal_s);

            string Kvitto_id_s = Textbox_kvitto_nr.Text.ToString().Trim();
            uint kvitto_id = Convert.ToUInt32(Kvitto_id_s);

            int idx = Kvitto_list.Alla_kvitton.FindIndex(item => item.Kvitto_Id == kvitto_id);

            if (idx < 0)
            {
                MessageBox.Show("Kvitto Id har inte hittats i databasen.");
                return;
            }

            if (antal_u > 0)
            {
                int idx1 = Kvitto_list.Alla_kvitton[idx].Varor.AllProdukts.FindIndex(item => item.Id == idu);

                if (idx1 < 0)
                {
                    MessageBox.Show("Produkt Id har inte hittats bland köpta varor.");
                    return;
                }

                int idx2 = Produkt_list_1.AllProdukts.FindIndex(item => item.Id == idu);

                if (idx1 < 0) // returnerar produkt som har utgått
                {
                    Produkt Ny_prod1 = new Produkt();

                    Ny_prod1.Id = idu;
                    Ny_prod1.Name = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Name"].Value);
                    Ny_prod1.Price = Convert.ToDouble(Convert.ToString(Dgr_retur.Rows[ind1].Cells["Price"].Value));
                    string type_s = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Type"].Value).Trim();
                    if (type_s.Equals("Bok") | type_s.Equals("bok"))
                    {
                        Ny_prod1.Produkt_type = Ptype.Bok;
                    }
                    else if (type_s.Equals("DVD") | type_s.Equals("dvd"))
                    {
                        Ny_prod1.Produkt_type = Ptype.DVD;
                    }
                    else if (type_s.Equals("Spel") | type_s.Equals("spel"))
                    {
                        Ny_prod1.Produkt_type = Ptype.Spel;
                    }
                    else if (type_s.Equals("Unknown") | type_s.Equals("unknown"))
                    {
                        Ny_prod1.Produkt_type = Ptype.Unknown;
                    }
                    else
                    {
                        MessageBox.Show("Produkttyp för retur är ogiltig");
                        return;
                    }

                    Ny_prod1.Author = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Author"].Value);
                    Ny_prod1.Genre = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Genre"].Value);
                    Ny_prod1.Format = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Format"].Value);
                    Ny_prod1.Language = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Language"].Value);
                    Ny_prod1.Platform = Convert.ToString(Dgr_retur.Rows[ind1].Cells["Platform"].Value);
                    Ny_prod1.Playtime = Convert.ToUInt32(Convert.ToString(Dgr_retur.Rows[ind1].Cells["Playtime"].Value));
                    Ny_prod1.Antal = 1;

                    Produkt_list_1.Add_new_product(Ny_prod1);
                }
                else
                {
                    Kvitto_list.Alla_kvitton[idx].Varor.AllProdukts[idx1].Antal -= 1;
                    Retur_korg.AllProdukts[idx1].Antal -= 1;
                    Produkt_list_1.AllProdukts[idx2].Antal += 1;

                }

            }
            else
            {
                MessageBox.Show("Alla varor av denna produkt typ har redan returnerats.");
            }

            Loaddata_control(Dgr_kassa_varor, Produkt_list_1);
            Loaddata_control(Dgr_retur, Retur_korg);

            Dgr_retur.ClearSelection();

        }

        public void Btn_Ladda_Retur_Click(TextBox Textbox_kvitto_nr, Forsaljningar Kvitto_list,
            DataGridView Dgr_retur, Button Btn_Skriv_kvitto)
        {
            Retur_korg = new Produkt_list();

            string s1 = Textbox_kvitto_nr.Text.ToString();

            if (s1.Length == 0)
            {
                MessageBox.Show("Giltigt kvittonummer måste anges");
                return;
            }

            uint retur_kvitto_id = Convert.ToUInt32(s1);

            if (Kvitto_list.Alla_kvitton.Count > 0) // 
            {
                int idx = Kvitto_list.Alla_kvitton.FindIndex(item => item.Kvitto_Id == retur_kvitto_id);

                if (idx >= 0)
                {
                    //Retur_korg = new Produkt_list();

                    Retur_korg = Kvitto_list.Alla_kvitton[idx].Varor.Copy();

                    //Loaddata(Dgr_retur, 2);

                    Loaddata_control(Dgr_retur, Retur_korg);

                    Btn_Skriv_kvitto.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Kvitto Id har inte hittats i databasen.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Inga köp i butiken har genomförts ännu.");
            }
            return;
        }

        public void Btn_Kop_Click(DataGridView Dgr_kundkorg, Produkt_list Produkt_list_1,
            Forsaljningar Kvitto_list,
            DataGridView Dgr_kassa_varor, Button Btn_Skriv_kvitto)
        {
            if (Dgr_kundkorg == null || Dgr_kundkorg.Rows.Count == 0)
            {
                MessageBox.Show("Finns inga varor i kundkorgen.");
                return;
            }
            else
            {
                Produkt_list_1.Subtract(Varukorg);

                if (Produkt_list_1.Errors > 0)
                {
                    return;
                }

                Kvitto Kvitto_tmp = new Kvitto();

                Kvitto_tmp.Datum = DateTime.Now;

                Kvitto_tmp.Varor = new Produkt_list();

                Kvitto_tmp.Varor = Varukorg.Copy();

                if (Kvitto_list.Alla_kvitton.Count == 0)
                {
                    Kvitto_tmp.Kvitto_Id = 0;
                }
                else
                {
                    Kvitto_tmp.Kvitto_Id = Kvitto_list.Alla_kvitton.OrderByDescending(p => p.Kvitto_Id).FirstOrDefault().Kvitto_Id + 1;
                }


                Kvitto_list.Alla_kvitton.Add(Kvitto_tmp);



                Varukorg = new Produkt_list();
            }


            Loaddata_control(Dgr_kundkorg, Varukorg);
            Loaddata_control(Dgr_kassa_varor, Produkt_list_1);

            Dgr_kassa_varor.ClearSelection();

            Btn_Skriv_kvitto.Enabled = true;
        }

        public void Btn_Till_kundkorg_Click(DataGridView Dgr_kassa_varor,
            Produkt_list Produkt_list_1, DataGridView Dgr_kundkorg, Button Btn_Skriv_kvitto)
        {
            if (Dgr_kassa_varor == null || Dgr_kassa_varor.Rows.Count == 0)
            {
                MessageBox.Show("Finns inga varor i butiken.");
                return;
            }
            else
            {
                int ind1 = 0;

                foreach (DataGridViewRow row in Dgr_kassa_varor.SelectedRows)
                {
                    ind1 = row.Index;
                }

                string antal_s = Convert.ToString(Dgr_kassa_varor.Rows[ind1].Cells["Antal"].Value);
                uint antal_varor = (uint)Convert.ToUInt32(antal_s);

                if (antal_varor == 0)
                {
                    MessageBox.Show("Kan inte lägga till kundkorg när antal varor på lager är = 0.");
                    return;
                }

                string ids = Convert.ToString(Dgr_kassa_varor.Rows[ind1].Cells["Id"].Value);
                uint idu = (uint)Convert.ToUInt32(ids);

                if (Varukorg.AllProdIDs.Count == 0) // new prod
                {
                    Produkt Prod_new = new Produkt();
                    int idx = Produkt_list_1.AllProdIDs.FindIndex(item => item == idu);

                    Prod_new.Id = Produkt_list_1.AllProdukts[idx].Id;
                    Prod_new.Name = Produkt_list_1.AllProdukts[idx].Name;
                    Prod_new.Author = Produkt_list_1.AllProdukts[idx].Author;
                    Prod_new.Antal = Produkt_list_1.AllProdukts[idx].Antal;
                    Prod_new.Format = Produkt_list_1.AllProdukts[idx].Format;
                    Prod_new.Platform = Produkt_list_1.AllProdukts[idx].Platform;
                    Prod_new.Playtime = Produkt_list_1.AllProdukts[idx].Playtime;
                    Prod_new.Price = Produkt_list_1.AllProdukts[idx].Price;
                    Prod_new.Produkt_type = Produkt_list_1.AllProdukts[idx].Produkt_type;
                    Prod_new.Genre = Produkt_list_1.AllProdukts[idx].Genre;
                    Prod_new.Language = Produkt_list_1.AllProdukts[idx].Language;

                    Varukorg.Add_new_product(Prod_new);
                    Varukorg.AllProdukts[Varukorg.AllProdukts.Count - 1].Id = idu; // restore id
                    Varukorg.AllProdIDs[Varukorg.AllProdIDs.Count - 1] = idu; // restore id
                    Varukorg.AllProdukts[Varukorg.AllProdukts.Count - 1].Antal = 1; // add 1
                }
                else
                {
                    if (Varukorg.AllProdIDs.Contains(idu)) // prod finns redan
                    {
                        int idx1 = Varukorg.AllProdIDs.FindIndex(item => item == idu);

                        if (antal_varor == Varukorg.AllProdukts[idx1].Antal)
                        {
                            MessageBox.Show("Alla varor av denna produkt typ som finns på lager har redan lagts till varukorg.");
                            return;
                        }

                        Varukorg.Add_existing_product(idu, 1);
                    }
                    else // ny typ av produkt lagts till varukorg
                    {
                        Produkt Prod_new = new Produkt();
                        int idx = Produkt_list_1.AllProdIDs.FindIndex(item => item == idu);

                        Prod_new.Id = Produkt_list_1.AllProdukts[idx].Id;
                        Prod_new.Name = Produkt_list_1.AllProdukts[idx].Name;
                        Prod_new.Author = Produkt_list_1.AllProdukts[idx].Author;
                        Prod_new.Antal = Produkt_list_1.AllProdukts[idx].Antal;
                        Prod_new.Format = Produkt_list_1.AllProdukts[idx].Format;
                        Prod_new.Platform = Produkt_list_1.AllProdukts[idx].Platform;
                        Prod_new.Playtime = Produkt_list_1.AllProdukts[idx].Playtime;
                        Prod_new.Price = Produkt_list_1.AllProdukts[idx].Price;
                        Prod_new.Produkt_type = Produkt_list_1.AllProdukts[idx].Produkt_type;
                        Prod_new.Genre = Produkt_list_1.AllProdukts[idx].Genre;
                        Prod_new.Language = Produkt_list_1.AllProdukts[idx].Language;


                        Varukorg.AllProdukts.Add(Prod_new);
                        Varukorg.AllProdIDs.Add(0);
                        Varukorg.AllProdukts[Varukorg.AllProdukts.Count - 1].Id = idu; // restore id
                        Varukorg.AllProdIDs[Varukorg.AllProdIDs.Count - 1] = idu; // restore id
                        Varukorg.AllProdukts[Varukorg.AllProdukts.Count - 1].Antal = 1; // add 1
                    }
                }


                Loaddata_control(Dgr_kundkorg, Varukorg);
                Dgr_kassa_varor.ClearSelection();
                Dgr_kassa_varor.Rows[ind1].Selected = true;

                Btn_Skriv_kvitto.Enabled = false;
            }
        }

        public void Btn_tabort_Click(DataGridView Dgr_Lager, Produkt_list Produkt_list_1)
        {
            if (Dgr_Lager == null || Dgr_Lager.Rows.Count == 0)
            {
                return;
            }
            else
            {
                int ind1 = 0;

                foreach (DataGridViewRow row in Dgr_Lager.SelectedRows)
                {
                    ind1 = row.Index;
                }

                string ids = Convert.ToString(Dgr_Lager.Rows[ind1].Cells["Id"].Value);
                uint idu = (uint)Convert.ToUInt32(ids);
                Produkt_list_1.Remove_existing_product(idu, 1);
                Loaddata_control(Dgr_Lager, Produkt_list_1);
                Dgr_Lager.ClearSelection();
                Dgr_Lager.Rows[ind1].Selected = true;
            }
        }

        public void Btn_addera_Click(DataGridView Dgr_Lager, Produkt_list Produkt_list_1)
        {
            if (Dgr_Lager == null || Dgr_Lager.Rows.Count == 0)
            {
                // nothing
            }
            else
            {
                int ind1 = 0;

                foreach (DataGridViewRow row in Dgr_Lager.SelectedRows)
                {
                    ind1 = row.Index;
                }

                string ids = Convert.ToString(Dgr_Lager.Rows[ind1].Cells["Id"].Value);
                uint idu = (uint)Convert.ToUInt32(ids);
                Produkt_list_1.Add_existing_product(idu, 1);
                Loaddata_control(Dgr_Lager, Produkt_list_1);
                Dgr_Lager.ClearSelection();
                Dgr_Lager.Rows[ind1].Selected = true;
            }
        }

    }

}
