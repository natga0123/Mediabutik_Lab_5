using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabutik_Lab4_1
{
    public partial class Ny_produkt : Form
    {
        Ptype Prodtype;
        public Ptype TypeEnum
        {
            get { return Prodtype; }
            private set { Prodtype = value; }
        }

        string Ptypes;
        public string TypeText
        {
            get { return Ptypes; }
            private set { Ptypes = value; }
        }

        string Pname;
        public string NameText
        {
            get { return Pname; }
            private set { Pname = value; }
        }

        double Pprice;
        public double PriceUint
        {
            get { return Pprice; }
            private set { Pprice = value; }
        }

        uint Pantal;
        public uint AntalUint
        {
            get { return Pantal; }
            private set { Pantal = value; }
        }

        string Pauthor;
        public string AuthorText
        {
            get { return Pauthor; }
            private set { Pauthor = value; }
        }

        string Pgenre;
        public string GenreText
        {
            get { return Pgenre; }
            private set { Pgenre = value; }
        }

        string Pformat;
        public string FormatText
        {
            get { return Pformat; }
            private set { Pformat = value; }
        }

        string Plang;
        public string LangText
        {
            get { return Plang; }
            private set { Plang = value; }
        }

        string Pplatform;
        public string PlatformText
        {
            get { return Pplatform; }
            private set { Pplatform = value; }
        }

        uint Ptid;
        public uint TidUint
        {
            get { return Ptid; }
            private set { Ptid = value; }
        }

        public Ny_produkt()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Combobox_type.SelectedIndex == -1)
            {
                MessageBox.Show("Produkt typ måste anges.");
                return;
            }

            bool DisableOK = false;
            TypeText = Combobox_type.SelectedItem.ToString();
            NameText = Textbox_name.Text.Trim();

            if (String.Equals(TypeText, "Bok"))
            {
                TypeEnum = Ptype.Bok;
            }
            else if (String.Equals(TypeText, "DVD"))
            {
                TypeEnum = Ptype.DVD;
            }
            else if (String.Equals(TypeText, "Spel"))
            {
                TypeEnum = Ptype.Spel;
            }
            else if (String.Equals(TypeText, "Odefinerad"))
            {
                TypeEnum = Ptype.Unknown;
            }

            if (TypeText.Length <= 0)
            {
                DisableOK = true;
            }

            if (NameText.Length <= 0)
            {
                DisableOK = true;
            }

            string Pris = Textbox_pris.Text.ToString().Trim();
            if (Pris.Length > 0)
            {
                PriceUint = Convert.ToDouble(Pris);
            }
            else
            {
                DisableOK = true;
            }

            string Antal = Textbox_antal.Text.ToString().Trim();
            if (Antal.Length > 0)
            {
                AntalUint = Convert.ToUInt32(Antal);
            }
            else
            {
                DisableOK = true;
            }

             AuthorText =   Textbox_author.Text.ToString().Trim();
             GenreText =    Textbox_genre.Text.ToString().Trim();
             FormatText =   Textbox_format.Text.ToString().Trim();
             LangText =     Textbox_language.Text.ToString().Trim();
             PlatformText = Textbox_platform.Text.ToString().Trim();

            string Speltid = Textbox_speltid.Text.ToString().Trim();
            if (Speltid.Length > 0)
            {
                TidUint = Convert.ToUInt32(Speltid);
            }
            else
            {
                TidUint = 0;
            }

            if (DisableOK == false)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //this.Close();
            }
            else{
                MessageBox.Show("Kontrollera att alla obligatoriska inmatningar är ifyllda korrekt.");
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void Combobox_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Combobox_type.SelectedItem.ToString() == "")
            {
                Textbox_name.Enabled = false;
                Textbox_name.Text = "";

                Textbox_pris.Enabled = false;
                Textbox_pris.Text = "";

                Textbox_antal.Enabled = false;
                Textbox_antal.Text = "";

                Textbox_author.Enabled = false;
                Textbox_author.Text = "";

                Textbox_genre.Enabled = false;
                Textbox_genre.Text = "";

                Textbox_format.Enabled = false;
                Textbox_format.Text = "";

                Textbox_language.Enabled = false;
                Textbox_language.Text = "";

                Textbox_platform.Enabled = false;
                Textbox_platform.Text = "";

                Textbox_speltid.Enabled = false;
                Textbox_speltid.Text = "";

            }
            else if (Combobox_type.SelectedItem.ToString() == "Bok")
            {
                Textbox_name.Enabled = true;
                //Textbox_name.Text = "";

                Textbox_pris.Enabled = true;
                //Textbox_pris.Text = "";

                Textbox_antal.Enabled = true;
                //Textbox_antal.Text = "";

                Textbox_author.Enabled = true;
                //Textbox_author.Text = "";

                Textbox_genre.Enabled = true;
                //Textbox_genre.Text = "";

                Textbox_format.Enabled = true;
                //Textbox_format.Text = "";

                Textbox_language.Enabled = true;
                //Textbox_language.Text = "";

                Textbox_platform.Enabled = false;
                Textbox_platform.Text = "";

                Textbox_speltid.Enabled = false;
                Textbox_speltid.Text = "";
            }
            else if (Combobox_type.SelectedItem.ToString() == "DVD")
            {
                Textbox_name.Enabled = true;
                //Textbox_name.Text = "";

                Textbox_pris.Enabled = true;
                //Textbox_pris.Text = "";

                Textbox_antal.Enabled = true;
                //Textbox_antal.Text = "";

                Textbox_author.Enabled = false;
                Textbox_author.Text = "";

                Textbox_genre.Enabled = false;
                Textbox_genre.Text = "";

                Textbox_format.Enabled = false;
                Textbox_format.Text = "";

                Textbox_language.Enabled = false;
                Textbox_language.Text = "";

                Textbox_platform.Enabled = false;
                Textbox_platform.Text = "";

                Textbox_speltid.Enabled = true;
                Textbox_speltid.Text = "";
            }
            else if (Combobox_type.SelectedItem.ToString() == "Spel")
            {
                Textbox_name.Enabled = true;
                //Textbox_name.Text = "";

                Textbox_pris.Enabled = true;
                //Textbox_pris.Text = "";

                Textbox_antal.Enabled = true;
                //Textbox_antal.Text = "";

                Textbox_author.Enabled = false;
                Textbox_author.Text = "";

                Textbox_genre.Enabled = false;
                Textbox_genre.Text = "";

                Textbox_format.Enabled = false;
                Textbox_format.Text = "";

                Textbox_language.Enabled = false;
                Textbox_language.Text = "";

                Textbox_platform.Enabled = true;
                Textbox_platform.Text = "";

                Textbox_speltid.Enabled = false;
                Textbox_speltid.Text = "";
            }
            else if (Combobox_type.SelectedItem.ToString() == "Odefinerad")
            {
                Textbox_name.Enabled = true;
                //Textbox_name.Text = "";

                Textbox_pris.Enabled = true;
                //Textbox_pris.Text = "";

                Textbox_antal.Enabled = true;
                //Textbox_antal.Text = "";

                Textbox_author.Enabled = true;
                Textbox_author.Text = "";

                Textbox_genre.Enabled = true;
                Textbox_genre.Text = "";

                Textbox_format.Enabled = true;
                Textbox_format.Text = "";

                Textbox_language.Enabled = true;
                Textbox_language.Text = "";

                Textbox_platform.Enabled = true;
                Textbox_platform.Text = "";

                Textbox_speltid.Enabled = true;
                Textbox_speltid.Text = "";
            }
        }

        private void Textbox_pris_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_pris.Text.Length == 0)
            {
                return;
            }

            double pris;
            try
            {
                pris = Double.Parse(Textbox_pris.Text);  //check value
                if(pris < 0)
                {
                    MessageBox.Show("Kan inte sätta negativt pris.");
                    Textbox_pris.Text = "";
                    //return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Textbox_pris.Text = "";
            }
        }

        private void Textbox_antal_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_antal.Text.Length==0)
            {
                return;
            }

            uint antal;
            try
            {
                antal = uint.Parse(Textbox_antal.Text);  //check value
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Textbox_antal.Text = "";
            }
        }

        private void Textbox_speltid_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_speltid.Text.Length == 0)
            {
                return;
            }

            uint speltid;
            try
            {
                speltid = uint.Parse(Textbox_speltid.Text);  //check value
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Textbox_speltid.Text = "";
            }
        }
    }
}
