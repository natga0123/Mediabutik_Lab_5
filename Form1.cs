using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mediabutik_Lab4_1
{
    
    public partial class MainForm_Mediabutik_1 : Form
    {
        public string filepath_produkt_list = "varor_1.csv";

        Controller_1 Controller;

        //Forsaljningar Controller.Kvitto_list;
        

        public DataTable Table_stat;

        public MainForm_Mediabutik_1()
        {
            InitializeComponent();
        }
       
        private void MainForm_Mediabutik_1_Load(object sender, EventArgs e)
        {
            Controller = new Controller_1();
            
            Controller.Produkt_list_1.Read_produkt_file(filepath_produkt_list);

            Controller.Loaddata_control(Dgr_kassa_varor, Controller.Produkt_list_1);

            //Controller.Kvitto_list = new Forsaljningar();

            string filepath_salda_varor = "Alla_kop_Ny_fil1.csv";

            if (File.Exists(filepath_salda_varor))
            {
                Controller.Kvitto_list.Load_from_file(filepath_salda_varor);
            }

            
            Btn_Skriv_kvitto.Enabled = false;

        }

        private void TextBox_NameSearch_TextChanged(object sender, EventArgs e)
        {
            Controller.Sortdata_control("Name", TextBox_NameSearch.Text, TextBox_NameSearch.Text, TextBox_TypeSearch.Text, Dgr_kassa_varor);
        }

        private void TextBox_TypeSearch_TextChanged(object sender, EventArgs e)
        {
            Controller.Sortdata_control("Type", TextBox_TypeSearch.Text, TextBox_NameSearch.Text, TextBox_TypeSearch.Text, Dgr_kassa_varor);
        }

        private void Kassa_tab_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 0)
            {
                Controller.Loaddata_control(Dgr_kassa_varor, Controller.Produkt_list_1);
            }
            else if (e.TabPageIndex == 1)
            {
                Controller.Loaddata_control(Dgr_Lager, Controller.Produkt_list_1);
            }
            else if (e.TabPageIndex == 2)
            {
                Controller.Load_statistics_control(Dgr_Top10, Dgr_Total,ComboBox_year_top10, 
                    ComboBox_Month_top10,ComboBox_year_all, ComboBox_Month_all, Controller.Kvitto_list);
            }
        }

        private void Btn_addera_Click(object sender, EventArgs e)
        {
            Controller.Btn_addera_Click( Dgr_Lager, Controller.Produkt_list_1);
        }

        private void Btn_tabort_Click(object sender, EventArgs e)
        {
            Controller.Btn_tabort_Click( Dgr_Lager, Controller.Produkt_list_1);
            
        }
        private void Btn_tabort_produkt_Click(object sender, EventArgs e)
        {
            int ind1 = 0;

            foreach (DataGridViewRow row in Dgr_Lager.SelectedRows)
            {
                ind1 = row.Index;
            }

            string ids = Convert.ToString(Dgr_Lager.Rows[ind1].Cells["Id"].Value);
            uint idu = (uint)Convert.ToUInt32(ids);

            string antal_s = Convert.ToString(Dgr_Lager.Rows[ind1].Cells["Antal"].Value);
            int antal_u = (int)Convert.ToInt32(antal_s);

            if (antal_u > 0)
            {
                Dialog_ja_nej dlg = new Dialog_ja_nej();

                if (dlg.ShowDialog(this) == DialogResult.Yes)
                {
                    Controller.Produkt_list_1.Remove_product(idu);
                    Controller.Loaddata_control(Dgr_Lager,Controller.Produkt_list_1);
                    Dgr_Lager.ClearSelection();
                }
            }
            else
            {
                Controller.Produkt_list_1.Remove_product(idu);
                Controller.Loaddata_control(Dgr_Lager, Controller.Produkt_list_1);
                Dgr_Lager.ClearSelection();
            }
        }

        private void Btn_Nyprod_Click(object sender, EventArgs e)
        {
            Ny_produkt dlg = new Ny_produkt();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Produkt Ny_prod1 = new Produkt();

                Ny_prod1.Id = 0; // temporary
                Ny_prod1.Name  = dlg.NameText;
                Ny_prod1.Price = dlg.PriceUint;
                Ny_prod1.Produkt_type = dlg.TypeEnum;
                Ny_prod1.Author = dlg.AuthorText;
                Ny_prod1.Genre = dlg.GenreText;
                Ny_prod1.Format = dlg.FormatText;
                Ny_prod1.Language = dlg.LangText;
                Ny_prod1.Platform = dlg.PlatformText;
                Ny_prod1.Playtime = dlg.TidUint;
                Ny_prod1.Antal = dlg.AntalUint;

                Controller.Produkt_list_1.Add_new_product(Ny_prod1);
                Controller.Loaddata_control(Dgr_Lager, Controller.Produkt_list_1);
            }
            
        }

        private void Btn_Till_kundkorg_Click(object sender, EventArgs e)
        {
            Controller.Btn_Till_kundkorg_Click(Dgr_kassa_varor,
             Controller.Produkt_list_1, Dgr_kundkorg, Btn_Skriv_kvitto);
        }

        private void Btn_Rensa_korg_Click(object sender, EventArgs e)
        {
            Controller.Varukorg = new Produkt_list("Varukorg");
            Controller.Loaddata_control(Dgr_kundkorg, Controller.Varukorg);
            Btn_Skriv_kvitto.Enabled = false;
        }

        private void Btn_Kop_Click(object sender, EventArgs e)
        {
            Controller.Btn_Kop_Click(Dgr_kundkorg, Controller.Produkt_list_1, Controller.Kvitto_list,
             Dgr_kassa_varor, Btn_Skriv_kvitto);

            uint this_kvitto_nr;

            this_kvitto_nr = Controller.Kvitto_list.Alla_kvitton[Controller.Kvitto_list.Alla_kvitton.Count - 1].Kvitto_Id;

            MessageBox.Show("Kvitto nr för detta köp är = " + this_kvitto_nr.ToString());

        }

        private void Textbox_kvitto_nr_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_kvitto_nr.Text.Length == 0)
            {
                return;
            }

            uint kvitto_id;
            try
            {
                kvitto_id = uint.Parse(Textbox_kvitto_nr.Text);  //check value
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Textbox_kvitto_nr.Text = "";
            }
        }

        private void Btn_Ladda_retur_Click(object sender, EventArgs e)
        {
            Controller.Btn_Ladda_Retur_Click(Textbox_kvitto_nr, Controller.Kvitto_list,
             Dgr_retur, Btn_Skriv_kvitto);
        }

        private void Btn_Retur_Click(object sender, EventArgs e)
        {
            Controller.Btn_Retur_Click(Dgr_retur, Dgr_kassa_varor, Textbox_kvitto_nr,
                Controller.Kvitto_list);
        }

        private void Btn_Retur_Klar_Click(object sender, EventArgs e)
        {
            Controller.Retur_korg = new Produkt_list();
            Textbox_kvitto_nr.Text = "";
            Dgr_retur.ClearSelection();
            Controller.Loaddata_control(Dgr_retur, Controller.Retur_korg);
        }

        private void Btn_Skriv_kvitto_Click(object sender, EventArgs e)
        {
            Controller.Kvitto_list.Alla_kvitton[Controller.Kvitto_list.Alla_kvitton.Count - 1].Skriv_ut_kvitto_pdf("");

        }

        private void MainForm_Mediabutik_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Produkt_list_1.Save_products_to_csv("");
            Controller.Kvitto_list.Save_to_csv("");
        }

        private void Btn_show_top10_Click(object sender, EventArgs e)
        {
            Controller.Controller_top10_click(ComboBox_year_top10, ComboBox_Month_top10,
            Controller.Kvitto_list, Dgr_Top10);
        }

        private void Btn_show_total_Click(object sender, EventArgs e)
        {
            Controller.Controller_total_click(ComboBox_year_all, ComboBox_Month_all,
            Controller.Kvitto_list, Dgr_Total);
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            string File_export_dir = "Export";
            bool exists = System.IO.Directory.Exists(File_export_dir);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(File_export_dir);
            }
            string File_export_path = File_export_dir + Path.DirectorySeparatorChar + "Export_Varulist_fran_Mediabutik.csv";

            if (File.Exists(File_export_path))
            {
                File.Delete(File_export_path);
            }

            Controller.Produkt_list_1.Save_products_to_csv(File_export_path);

            string Produkts_innan_export = "Produktlistan_innan_export.csv";

            if (File.Exists(Produkts_innan_export))
            {
                File.Delete(Produkts_innan_export);
            }

            Controller.Produkt_list_1.Save_products_to_csv(Produkts_innan_export);
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            string File_import_dir = "Import";
            bool exists = System.IO.Directory.Exists(File_import_dir);

            if (!exists)
            {
                MessageBox.Show("Katalogen Import som ska innehålla Produktlistan från SimpleMedia i XML format finns inte.");
            }
            else
            {
                DirectoryInfo Dir_inf = new DirectoryInfo(File_import_dir);

                int N_XML = Dir_inf.GetFiles("*.xml", SearchOption.AllDirectories).Length;

                if (N_XML == 1)
                {
                    FileInfo[] File_Inf = Dir_inf.GetFiles("*.xml");
                    string XML_file_name = Path.GetFullPath(File_import_dir) + Path.DirectorySeparatorChar + File_Inf[0].Name;

                    Produkt_list Produkt_list_innan_exp = new Produkt_list("innan_exp");

                    if (System.IO.File.Exists("Produktlistan_innan_export.csv"))
                    {
                        Produkt_list_innan_exp.Read_produkt_file("Produktlistan_innan_export.csv");
                    }                    

                    Controller.Produkt_list_1.Update_Produkt_list_from_XML(XML_file_name, Produkt_list_innan_exp);
                    Controller.Loaddata_control(Dgr_kassa_varor, Controller.Produkt_list_1);
                }
                else
                {
                    MessageBox.Show("I katalogen Import ska finnas 1, och bara 1 *.xml fil från SimpleMedia.");
                }
            }
        }
    }
}
