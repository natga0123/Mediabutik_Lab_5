namespace Mediabutik_Lab4_1
{
    partial class Ny_produkt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Combobox_type = new System.Windows.Forms.ComboBox();
            this.Textbox_name = new System.Windows.Forms.TextBox();
            this.Textbox_pris = new System.Windows.Forms.TextBox();
            this.Textbox_author = new System.Windows.Forms.TextBox();
            this.Textbox_antal = new System.Windows.Forms.TextBox();
            this.Textbox_platform = new System.Windows.Forms.TextBox();
            this.Textbox_genre = new System.Windows.Forms.TextBox();
            this.Textbox_speltid = new System.Windows.Forms.TextBox();
            this.Textbox_format = new System.Windows.Forms.TextBox();
            this.Textbox_language = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Lbl_prod_type = new System.Windows.Forms.Label();
            this.Lbl_prod_name = new System.Windows.Forms.Label();
            this.Lbl_prod_price = new System.Windows.Forms.Label();
            this.Lbl_prod_forfattare = new System.Windows.Forms.Label();
            this.Lbl_genre = new System.Windows.Forms.Label();
            this.Lbl_format = new System.Windows.Forms.Label();
            this.Lbl_language = new System.Windows.Forms.Label();
            this.Lbl_platform = new System.Windows.Forms.Label();
            this.Lbl_playtime = new System.Windows.Forms.Label();
            this.Lbl_antal = new System.Windows.Forms.Label();
            this.Grpbox_nyprod_obligatoriska = new System.Windows.Forms.GroupBox();
            this.Grpbox_nyprod_obligatoriska.SuspendLayout();
            this.SuspendLayout();
            // 
            // Combobox_type
            // 
            this.Combobox_type.FormattingEnabled = true;
            this.Combobox_type.Items.AddRange(new object[] {
            "Bok",
            "DVD",
            "Spel",
            "Odefinerad"});
            this.Combobox_type.Location = new System.Drawing.Point(21, 49);
            this.Combobox_type.Name = "Combobox_type";
            this.Combobox_type.Size = new System.Drawing.Size(121, 24);
            this.Combobox_type.TabIndex = 0;
            this.Combobox_type.SelectionChangeCommitted += new System.EventHandler(this.Combobox_type_SelectionChangeCommitted);
            // 
            // Textbox_name
            // 
            this.Textbox_name.Enabled = false;
            this.Textbox_name.Location = new System.Drawing.Point(23, 115);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(601, 22);
            this.Textbox_name.TabIndex = 1;
            // 
            // Textbox_pris
            // 
            this.Textbox_pris.Enabled = false;
            this.Textbox_pris.Location = new System.Drawing.Point(23, 165);
            this.Textbox_pris.Name = "Textbox_pris";
            this.Textbox_pris.Size = new System.Drawing.Size(119, 22);
            this.Textbox_pris.TabIndex = 2;
            this.Textbox_pris.TextChanged += new System.EventHandler(this.Textbox_pris_TextChanged);
            // 
            // Textbox_author
            // 
            this.Textbox_author.Enabled = false;
            this.Textbox_author.Location = new System.Drawing.Point(35, 260);
            this.Textbox_author.Name = "Textbox_author";
            this.Textbox_author.Size = new System.Drawing.Size(119, 22);
            this.Textbox_author.TabIndex = 3;
            // 
            // Textbox_antal
            // 
            this.Textbox_antal.Enabled = false;
            this.Textbox_antal.Location = new System.Drawing.Point(192, 165);
            this.Textbox_antal.Name = "Textbox_antal";
            this.Textbox_antal.Size = new System.Drawing.Size(119, 22);
            this.Textbox_antal.TabIndex = 4;
            this.Textbox_antal.TextChanged += new System.EventHandler(this.Textbox_antal_TextChanged);
            // 
            // Textbox_platform
            // 
            this.Textbox_platform.Enabled = false;
            this.Textbox_platform.Location = new System.Drawing.Point(35, 316);
            this.Textbox_platform.Name = "Textbox_platform";
            this.Textbox_platform.Size = new System.Drawing.Size(119, 22);
            this.Textbox_platform.TabIndex = 5;
            // 
            // Textbox_genre
            // 
            this.Textbox_genre.Enabled = false;
            this.Textbox_genre.Location = new System.Drawing.Point(204, 260);
            this.Textbox_genre.Name = "Textbox_genre";
            this.Textbox_genre.Size = new System.Drawing.Size(119, 22);
            this.Textbox_genre.TabIndex = 6;
            // 
            // Textbox_speltid
            // 
            this.Textbox_speltid.Enabled = false;
            this.Textbox_speltid.Location = new System.Drawing.Point(204, 316);
            this.Textbox_speltid.Name = "Textbox_speltid";
            this.Textbox_speltid.Size = new System.Drawing.Size(119, 22);
            this.Textbox_speltid.TabIndex = 7;
            this.Textbox_speltid.TextChanged += new System.EventHandler(this.Textbox_speltid_TextChanged);
            // 
            // Textbox_format
            // 
            this.Textbox_format.Enabled = false;
            this.Textbox_format.Location = new System.Drawing.Point(363, 260);
            this.Textbox_format.Name = "Textbox_format";
            this.Textbox_format.Size = new System.Drawing.Size(119, 22);
            this.Textbox_format.TabIndex = 8;
            // 
            // Textbox_language
            // 
            this.Textbox_language.Enabled = false;
            this.Textbox_language.Location = new System.Drawing.Point(517, 260);
            this.Textbox_language.Name = "Textbox_language";
            this.Textbox_language.Size = new System.Drawing.Size(119, 22);
            this.Textbox_language.TabIndex = 9;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(204, 363);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(119, 30);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "Spara";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(363, 363);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(119, 30);
            this.Btn_cancel.TabIndex = 11;
            this.Btn_cancel.Text = "Avbryt";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Lbl_prod_type
            // 
            this.Lbl_prod_type.AutoSize = true;
            this.Lbl_prod_type.Location = new System.Drawing.Point(20, 29);
            this.Lbl_prod_type.Name = "Lbl_prod_type";
            this.Lbl_prod_type.Size = new System.Drawing.Size(84, 17);
            this.Lbl_prod_type.TabIndex = 12;
            this.Lbl_prod_type.Text = "Produkt typ:";
            // 
            // Lbl_prod_name
            // 
            this.Lbl_prod_name.AutoSize = true;
            this.Lbl_prod_name.Location = new System.Drawing.Point(20, 85);
            this.Lbl_prod_name.Name = "Lbl_prod_name";
            this.Lbl_prod_name.Size = new System.Drawing.Size(100, 17);
            this.Lbl_prod_name.TabIndex = 13;
            this.Lbl_prod_name.Text = "Produkt namn:";
            // 
            // Lbl_prod_price
            // 
            this.Lbl_prod_price.AutoSize = true;
            this.Lbl_prod_price.Location = new System.Drawing.Point(20, 145);
            this.Lbl_prod_price.Name = "Lbl_prod_price";
            this.Lbl_prod_price.Size = new System.Drawing.Size(88, 17);
            this.Lbl_prod_price.TabIndex = 14;
            this.Lbl_prod_price.Text = "Produkt pris:";
            // 
            // Lbl_prod_forfattare
            // 
            this.Lbl_prod_forfattare.AutoSize = true;
            this.Lbl_prod_forfattare.Location = new System.Drawing.Point(32, 240);
            this.Lbl_prod_forfattare.Name = "Lbl_prod_forfattare";
            this.Lbl_prod_forfattare.Size = new System.Drawing.Size(74, 17);
            this.Lbl_prod_forfattare.TabIndex = 15;
            this.Lbl_prod_forfattare.Text = "Författare:";
            // 
            // Lbl_genre
            // 
            this.Lbl_genre.AutoSize = true;
            this.Lbl_genre.Location = new System.Drawing.Point(201, 240);
            this.Lbl_genre.Name = "Lbl_genre";
            this.Lbl_genre.Size = new System.Drawing.Size(52, 17);
            this.Lbl_genre.TabIndex = 16;
            this.Lbl_genre.Text = "Genre:";
            // 
            // Lbl_format
            // 
            this.Lbl_format.AutoSize = true;
            this.Lbl_format.Location = new System.Drawing.Point(360, 240);
            this.Lbl_format.Name = "Lbl_format";
            this.Lbl_format.Size = new System.Drawing.Size(56, 17);
            this.Lbl_format.TabIndex = 17;
            this.Lbl_format.Text = "Format:";
            // 
            // Lbl_language
            // 
            this.Lbl_language.AutoSize = true;
            this.Lbl_language.Location = new System.Drawing.Point(514, 240);
            this.Lbl_language.Name = "Lbl_language";
            this.Lbl_language.Size = new System.Drawing.Size(49, 17);
            this.Lbl_language.TabIndex = 18;
            this.Lbl_language.Text = "Språk:";
            // 
            // Lbl_platform
            // 
            this.Lbl_platform.AutoSize = true;
            this.Lbl_platform.Location = new System.Drawing.Point(32, 290);
            this.Lbl_platform.Name = "Lbl_platform";
            this.Lbl_platform.Size = new System.Drawing.Size(64, 17);
            this.Lbl_platform.TabIndex = 19;
            this.Lbl_platform.Text = "Platform:";
            // 
            // Lbl_playtime
            // 
            this.Lbl_playtime.AutoSize = true;
            this.Lbl_playtime.Location = new System.Drawing.Point(201, 290);
            this.Lbl_playtime.Name = "Lbl_playtime";
            this.Lbl_playtime.Size = new System.Drawing.Size(55, 17);
            this.Lbl_playtime.TabIndex = 20;
            this.Lbl_playtime.Text = "Speltid:";
            // 
            // Lbl_antal
            // 
            this.Lbl_antal.AutoSize = true;
            this.Lbl_antal.Location = new System.Drawing.Point(189, 145);
            this.Lbl_antal.Name = "Lbl_antal";
            this.Lbl_antal.Size = new System.Drawing.Size(44, 17);
            this.Lbl_antal.TabIndex = 21;
            this.Lbl_antal.Text = "Antal:";
            // 
            // Grpbox_nyprod_obligatoriska
            // 
            this.Grpbox_nyprod_obligatoriska.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Lbl_antal);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Lbl_prod_price);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Lbl_prod_name);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Lbl_prod_type);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Textbox_antal);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Textbox_pris);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Textbox_name);
            this.Grpbox_nyprod_obligatoriska.Controls.Add(this.Combobox_type);
            this.Grpbox_nyprod_obligatoriska.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grpbox_nyprod_obligatoriska.Location = new System.Drawing.Point(12, 7);
            this.Grpbox_nyprod_obligatoriska.Name = "Grpbox_nyprod_obligatoriska";
            this.Grpbox_nyprod_obligatoriska.Size = new System.Drawing.Size(648, 222);
            this.Grpbox_nyprod_obligatoriska.TabIndex = 22;
            this.Grpbox_nyprod_obligatoriska.TabStop = false;
            this.Grpbox_nyprod_obligatoriska.Text = "Obligatoriska inmatningar:";
            // 
            // Ny_produkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 413);
            this.Controls.Add(this.Grpbox_nyprod_obligatoriska);
            this.Controls.Add(this.Lbl_playtime);
            this.Controls.Add(this.Lbl_platform);
            this.Controls.Add(this.Lbl_language);
            this.Controls.Add(this.Lbl_format);
            this.Controls.Add(this.Lbl_genre);
            this.Controls.Add(this.Lbl_prod_forfattare);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Textbox_language);
            this.Controls.Add(this.Textbox_format);
            this.Controls.Add(this.Textbox_speltid);
            this.Controls.Add(this.Textbox_genre);
            this.Controls.Add(this.Textbox_platform);
            this.Controls.Add(this.Textbox_author);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ny_produkt";
            this.Text = "Ny_produkt";
            this.Grpbox_nyprod_obligatoriska.ResumeLayout(false);
            this.Grpbox_nyprod_obligatoriska.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combobox_type;
        private System.Windows.Forms.TextBox Textbox_name;
        private System.Windows.Forms.TextBox Textbox_pris;
        private System.Windows.Forms.TextBox Textbox_author;
        private System.Windows.Forms.TextBox Textbox_antal;
        private System.Windows.Forms.TextBox Textbox_platform;
        private System.Windows.Forms.TextBox Textbox_genre;
        private System.Windows.Forms.TextBox Textbox_speltid;
        private System.Windows.Forms.TextBox Textbox_format;
        private System.Windows.Forms.TextBox Textbox_language;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Label Lbl_prod_type;
        private System.Windows.Forms.Label Lbl_prod_name;
        private System.Windows.Forms.Label Lbl_prod_price;
        private System.Windows.Forms.Label Lbl_prod_forfattare;
        private System.Windows.Forms.Label Lbl_genre;
        private System.Windows.Forms.Label Lbl_format;
        private System.Windows.Forms.Label Lbl_language;
        private System.Windows.Forms.Label Lbl_platform;
        private System.Windows.Forms.Label Lbl_playtime;
        private System.Windows.Forms.Label Lbl_antal;
        private System.Windows.Forms.GroupBox Grpbox_nyprod_obligatoriska;
    }
}