namespace Mediabutik_Lab4_1
{
    partial class MainForm_Mediabutik_1
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
            this.Kassa_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Retur_Klar = new System.Windows.Forms.Button();
            this.Btn_Skriv_kvitto = new System.Windows.Forms.Button();
            this.Btn_Kop = new System.Windows.Forms.Button();
            this.Btn_Ladda_retur = new System.Windows.Forms.Button();
            this.Lbl_retur_id = new System.Windows.Forms.Label();
            this.Textbox_kvitto_nr = new System.Windows.Forms.TextBox();
            this.Btn_Retur = new System.Windows.Forms.Button();
            this.Dgr_retur = new System.Windows.Forms.DataGridView();
            this.Label_Retur = new System.Windows.Forms.Label();
            this.Label_kundkorg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Namn = new System.Windows.Forms.Label();
            this.Btn_Rensa_korg = new System.Windows.Forms.Button();
            this.TextBox_TypeSearch = new System.Windows.Forms.TextBox();
            this.TextBox_NameSearch = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.Dgr_kundkorg = new System.Windows.Forms.DataGridView();
            this.Btn_Till_kundkorg = new System.Windows.Forms.Button();
            this.Dgr_kassa_varor = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_tabort_produkt = new System.Windows.Forms.Button();
            this.Btn_Nyprod = new System.Windows.Forms.Button();
            this.Btn_tabort = new System.Windows.Forms.Button();
            this.Btn_addera = new System.Windows.Forms.Button();
            this.Dgr_Lager = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_show_total = new System.Windows.Forms.Button();
            this.ComboBox_Month_all = new System.Windows.Forms.ComboBox();
            this.ComboBox_year_all = new System.Windows.Forms.ComboBox();
            this.Lbl_Month_total = new System.Windows.Forms.Label();
            this.Lbl_year_total = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Dgr_Total = new System.Windows.Forms.DataGridView();
            this.Btn_show_top10 = new System.Windows.Forms.Button();
            this.ComboBox_Month_top10 = new System.Windows.Forms.ComboBox();
            this.ComboBox_year_top10 = new System.Windows.Forms.ComboBox();
            this.Lbl_Month = new System.Windows.Forms.Label();
            this.Lbl_year = new System.Windows.Forms.Label();
            this.Lbl_Best_10 = new System.Windows.Forms.Label();
            this.Dgr_Top10 = new System.Windows.Forms.DataGridView();
            this.Btn_Export = new System.Windows.Forms.Button();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.Kassa_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_retur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_kundkorg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_kassa_varor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Lager)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Top10)).BeginInit();
            this.SuspendLayout();
            // 
            // Kassa_tab
            // 
            this.Kassa_tab.Controls.Add(this.tabPage1);
            this.Kassa_tab.Controls.Add(this.tabPage2);
            this.Kassa_tab.Controls.Add(this.tabPage3);
            this.Kassa_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kassa_tab.Location = new System.Drawing.Point(0, 0);
            this.Kassa_tab.Name = "Kassa_tab";
            this.Kassa_tab.SelectedIndex = 0;
            this.Kassa_tab.Size = new System.Drawing.Size(982, 798);
            this.Kassa_tab.TabIndex = 0;
            this.Kassa_tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.Kassa_tab_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Import);
            this.tabPage1.Controls.Add(this.Btn_Export);
            this.tabPage1.Controls.Add(this.Btn_Retur_Klar);
            this.tabPage1.Controls.Add(this.Btn_Skriv_kvitto);
            this.tabPage1.Controls.Add(this.Btn_Kop);
            this.tabPage1.Controls.Add(this.Btn_Ladda_retur);
            this.tabPage1.Controls.Add(this.Lbl_retur_id);
            this.tabPage1.Controls.Add(this.Textbox_kvitto_nr);
            this.tabPage1.Controls.Add(this.Btn_Retur);
            this.tabPage1.Controls.Add(this.Dgr_retur);
            this.tabPage1.Controls.Add(this.Label_Retur);
            this.tabPage1.Controls.Add(this.Label_kundkorg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Label_Namn);
            this.tabPage1.Controls.Add(this.Btn_Rensa_korg);
            this.tabPage1.Controls.Add(this.TextBox_TypeSearch);
            this.tabPage1.Controls.Add(this.TextBox_NameSearch);
            this.tabPage1.Controls.Add(this.search_label);
            this.tabPage1.Controls.Add(this.Dgr_kundkorg);
            this.tabPage1.Controls.Add(this.Btn_Till_kundkorg);
            this.tabPage1.Controls.Add(this.Dgr_kassa_varor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 769);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kassa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_Retur_Klar
            // 
            this.Btn_Retur_Klar.Location = new System.Drawing.Point(858, 625);
            this.Btn_Retur_Klar.Name = "Btn_Retur_Klar";
            this.Btn_Retur_Klar.Size = new System.Drawing.Size(108, 60);
            this.Btn_Retur_Klar.TabIndex = 22;
            this.Btn_Retur_Klar.Text = "Returen\r\när klar";
            this.Btn_Retur_Klar.UseVisualStyleBackColor = true;
            this.Btn_Retur_Klar.Click += new System.EventHandler(this.Btn_Retur_Klar_Click);
            // 
            // Btn_Skriv_kvitto
            // 
            this.Btn_Skriv_kvitto.Location = new System.Drawing.Point(858, 456);
            this.Btn_Skriv_kvitto.Name = "Btn_Skriv_kvitto";
            this.Btn_Skriv_kvitto.Size = new System.Drawing.Size(108, 60);
            this.Btn_Skriv_kvitto.TabIndex = 21;
            this.Btn_Skriv_kvitto.Text = "Skriv ut\r\nKvitto";
            this.Btn_Skriv_kvitto.UseVisualStyleBackColor = true;
            this.Btn_Skriv_kvitto.Click += new System.EventHandler(this.Btn_Skriv_kvitto_Click);
            // 
            // Btn_Kop
            // 
            this.Btn_Kop.Location = new System.Drawing.Point(858, 390);
            this.Btn_Kop.Name = "Btn_Kop";
            this.Btn_Kop.Size = new System.Drawing.Size(108, 60);
            this.Btn_Kop.TabIndex = 20;
            this.Btn_Kop.Text = "Genomför\r\nKöp";
            this.Btn_Kop.UseVisualStyleBackColor = true;
            this.Btn_Kop.Click += new System.EventHandler(this.Btn_Kop_Click);
            // 
            // Btn_Ladda_retur
            // 
            this.Btn_Ladda_retur.Location = new System.Drawing.Point(270, 530);
            this.Btn_Ladda_retur.Name = "Btn_Ladda_retur";
            this.Btn_Ladda_retur.Size = new System.Drawing.Size(97, 23);
            this.Btn_Ladda_retur.TabIndex = 19;
            this.Btn_Ladda_retur.Text = "Ladda kvitto";
            this.Btn_Ladda_retur.UseVisualStyleBackColor = true;
            this.Btn_Ladda_retur.Click += new System.EventHandler(this.Btn_Ladda_retur_Click);
            // 
            // Lbl_retur_id
            // 
            this.Lbl_retur_id.AutoSize = true;
            this.Lbl_retur_id.Location = new System.Drawing.Point(81, 530);
            this.Lbl_retur_id.Name = "Lbl_retur_id";
            this.Lbl_retur_id.Size = new System.Drawing.Size(64, 17);
            this.Lbl_retur_id.TabIndex = 18;
            this.Lbl_retur_id.Text = "Kvitto nr:";
            // 
            // Textbox_kvitto_nr
            // 
            this.Textbox_kvitto_nr.Location = new System.Drawing.Point(147, 530);
            this.Textbox_kvitto_nr.Name = "Textbox_kvitto_nr";
            this.Textbox_kvitto_nr.Size = new System.Drawing.Size(107, 22);
            this.Textbox_kvitto_nr.TabIndex = 17;
            this.Textbox_kvitto_nr.TextChanged += new System.EventHandler(this.Textbox_kvitto_nr_TextChanged);
            // 
            // Btn_Retur
            // 
            this.Btn_Retur.Location = new System.Drawing.Point(858, 559);
            this.Btn_Retur.Name = "Btn_Retur";
            this.Btn_Retur.Size = new System.Drawing.Size(108, 60);
            this.Btn_Retur.TabIndex = 15;
            this.Btn_Retur.Text = "Returnera\r\nen vald vara";
            this.Btn_Retur.UseVisualStyleBackColor = true;
            this.Btn_Retur.Click += new System.EventHandler(this.Btn_Retur_Click);
            // 
            // Dgr_retur
            // 
            this.Dgr_retur.AllowUserToAddRows = false;
            this.Dgr_retur.AllowUserToDeleteRows = false;
            this.Dgr_retur.AllowUserToResizeColumns = false;
            this.Dgr_retur.AllowUserToResizeRows = false;
            this.Dgr_retur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_retur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_retur.Location = new System.Drawing.Point(3, 559);
            this.Dgr_retur.MultiSelect = false;
            this.Dgr_retur.Name = "Dgr_retur";
            this.Dgr_retur.ReadOnly = true;
            this.Dgr_retur.RowHeadersWidth = 51;
            this.Dgr_retur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_retur.RowTemplate.Height = 24;
            this.Dgr_retur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_retur.Size = new System.Drawing.Size(843, 195);
            this.Dgr_retur.TabIndex = 14;
            // 
            // Label_Retur
            // 
            this.Label_Retur.AutoSize = true;
            this.Label_Retur.Location = new System.Drawing.Point(6, 530);
            this.Label_Retur.Name = "Label_Retur";
            this.Label_Retur.Size = new System.Drawing.Size(43, 17);
            this.Label_Retur.TabIndex = 13;
            this.Label_Retur.Text = "Retur";
            // 
            // Label_kundkorg
            // 
            this.Label_kundkorg.AutoSize = true;
            this.Label_kundkorg.Location = new System.Drawing.Point(8, 304);
            this.Label_kundkorg.Name = "Label_kundkorg";
            this.Label_kundkorg.Size = new System.Drawing.Size(69, 17);
            this.Label_kundkorg.TabIndex = 11;
            this.Label_kundkorg.Text = "Kundkorg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Typ:";
            // 
            // Label_Namn
            // 
            this.Label_Namn.AutoSize = true;
            this.Label_Namn.Location = new System.Drawing.Point(205, 3);
            this.Label_Namn.Name = "Label_Namn";
            this.Label_Namn.Size = new System.Drawing.Size(49, 17);
            this.Label_Namn.TabIndex = 9;
            this.Label_Namn.Text = "Namn:";
            // 
            // Btn_Rensa_korg
            // 
            this.Btn_Rensa_korg.Location = new System.Drawing.Point(857, 324);
            this.Btn_Rensa_korg.Name = "Btn_Rensa_korg";
            this.Btn_Rensa_korg.Size = new System.Drawing.Size(108, 60);
            this.Btn_Rensa_korg.TabIndex = 8;
            this.Btn_Rensa_korg.Text = "Ångra påbörjat köp\r\ntöm kundkorg";
            this.Btn_Rensa_korg.UseVisualStyleBackColor = true;
            this.Btn_Rensa_korg.Click += new System.EventHandler(this.Btn_Rensa_korg_Click);
            // 
            // TextBox_TypeSearch
            // 
            this.TextBox_TypeSearch.Location = new System.Drawing.Point(325, 34);
            this.TextBox_TypeSearch.Name = "TextBox_TypeSearch";
            this.TextBox_TypeSearch.Size = new System.Drawing.Size(100, 22);
            this.TextBox_TypeSearch.TabIndex = 5;
            this.TextBox_TypeSearch.TextChanged += new System.EventHandler(this.TextBox_TypeSearch_TextChanged);
            // 
            // TextBox_NameSearch
            // 
            this.TextBox_NameSearch.Location = new System.Drawing.Point(208, 34);
            this.TextBox_NameSearch.Name = "TextBox_NameSearch";
            this.TextBox_NameSearch.Size = new System.Drawing.Size(100, 22);
            this.TextBox_NameSearch.TabIndex = 4;
            this.TextBox_NameSearch.TextChanged += new System.EventHandler(this.TextBox_NameSearch_TextChanged);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(144, 37);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(36, 17);
            this.search_label.TabIndex = 3;
            this.search_label.Text = "Sök:";
            // 
            // Dgr_kundkorg
            // 
            this.Dgr_kundkorg.AllowUserToAddRows = false;
            this.Dgr_kundkorg.AllowUserToDeleteRows = false;
            this.Dgr_kundkorg.AllowUserToResizeColumns = false;
            this.Dgr_kundkorg.AllowUserToResizeRows = false;
            this.Dgr_kundkorg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_kundkorg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_kundkorg.Location = new System.Drawing.Point(6, 324);
            this.Dgr_kundkorg.MultiSelect = false;
            this.Dgr_kundkorg.Name = "Dgr_kundkorg";
            this.Dgr_kundkorg.ReadOnly = true;
            this.Dgr_kundkorg.RowHeadersWidth = 51;
            this.Dgr_kundkorg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_kundkorg.RowTemplate.Height = 24;
            this.Dgr_kundkorg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_kundkorg.Size = new System.Drawing.Size(843, 195);
            this.Dgr_kundkorg.TabIndex = 2;
            // 
            // Btn_Till_kundkorg
            // 
            this.Btn_Till_kundkorg.Location = new System.Drawing.Point(857, 66);
            this.Btn_Till_kundkorg.Name = "Btn_Till_kundkorg";
            this.Btn_Till_kundkorg.Size = new System.Drawing.Size(108, 60);
            this.Btn_Till_kundkorg.TabIndex = 1;
            this.Btn_Till_kundkorg.Text = "Lägg varan\r\ni kundkorg";
            this.Btn_Till_kundkorg.UseVisualStyleBackColor = true;
            this.Btn_Till_kundkorg.Click += new System.EventHandler(this.Btn_Till_kundkorg_Click);
            // 
            // Dgr_kassa_varor
            // 
            this.Dgr_kassa_varor.AllowUserToAddRows = false;
            this.Dgr_kassa_varor.AllowUserToDeleteRows = false;
            this.Dgr_kassa_varor.AllowUserToResizeColumns = false;
            this.Dgr_kassa_varor.AllowUserToResizeRows = false;
            this.Dgr_kassa_varor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Dgr_kassa_varor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_kassa_varor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_kassa_varor.Location = new System.Drawing.Point(8, 66);
            this.Dgr_kassa_varor.MultiSelect = false;
            this.Dgr_kassa_varor.Name = "Dgr_kassa_varor";
            this.Dgr_kassa_varor.ReadOnly = true;
            this.Dgr_kassa_varor.RowHeadersWidth = 51;
            this.Dgr_kassa_varor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_kassa_varor.RowTemplate.Height = 24;
            this.Dgr_kassa_varor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_kassa_varor.Size = new System.Drawing.Size(843, 235);
            this.Dgr_kassa_varor.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_tabort_produkt);
            this.tabPage2.Controls.Add(this.Btn_Nyprod);
            this.tabPage2.Controls.Add(this.Btn_tabort);
            this.tabPage2.Controls.Add(this.Btn_addera);
            this.tabPage2.Controls.Add(this.Dgr_Lager);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 769);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_tabort_produkt
            // 
            this.Btn_tabort_produkt.Location = new System.Drawing.Point(845, 214);
            this.Btn_tabort_produkt.Name = "Btn_tabort_produkt";
            this.Btn_tabort_produkt.Size = new System.Drawing.Size(110, 50);
            this.Btn_tabort_produkt.TabIndex = 4;
            this.Btn_tabort_produkt.Text = "Ta bort Produkt";
            this.Btn_tabort_produkt.UseVisualStyleBackColor = true;
            this.Btn_tabort_produkt.Click += new System.EventHandler(this.Btn_tabort_produkt_Click);
            // 
            // Btn_Nyprod
            // 
            this.Btn_Nyprod.Location = new System.Drawing.Point(845, 149);
            this.Btn_Nyprod.Name = "Btn_Nyprod";
            this.Btn_Nyprod.Size = new System.Drawing.Size(110, 50);
            this.Btn_Nyprod.TabIndex = 3;
            this.Btn_Nyprod.Text = "Lägg till\r\nny produkt";
            this.Btn_Nyprod.UseVisualStyleBackColor = true;
            this.Btn_Nyprod.Click += new System.EventHandler(this.Btn_Nyprod_Click);
            // 
            // Btn_tabort
            // 
            this.Btn_tabort.Location = new System.Drawing.Point(845, 84);
            this.Btn_tabort.Name = "Btn_tabort";
            this.Btn_tabort.Size = new System.Drawing.Size(110, 50);
            this.Btn_tabort.TabIndex = 2;
            this.Btn_tabort.Text = "Minska antalet\r\nvaror";
            this.Btn_tabort.UseVisualStyleBackColor = true;
            this.Btn_tabort.Click += new System.EventHandler(this.Btn_tabort_Click);
            // 
            // Btn_addera
            // 
            this.Btn_addera.Location = new System.Drawing.Point(845, 19);
            this.Btn_addera.Name = "Btn_addera";
            this.Btn_addera.Size = new System.Drawing.Size(110, 50);
            this.Btn_addera.TabIndex = 1;
            this.Btn_addera.Text = "Öka antalet \r\nvaror";
            this.Btn_addera.UseVisualStyleBackColor = true;
            this.Btn_addera.Click += new System.EventHandler(this.Btn_addera_Click);
            // 
            // Dgr_Lager
            // 
            this.Dgr_Lager.AllowUserToAddRows = false;
            this.Dgr_Lager.AllowUserToDeleteRows = false;
            this.Dgr_Lager.AllowUserToResizeColumns = false;
            this.Dgr_Lager.AllowUserToResizeRows = false;
            this.Dgr_Lager.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Dgr_Lager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_Lager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_Lager.Location = new System.Drawing.Point(8, 19);
            this.Dgr_Lager.MultiSelect = false;
            this.Dgr_Lager.Name = "Dgr_Lager";
            this.Dgr_Lager.ReadOnly = true;
            this.Dgr_Lager.RowHeadersWidth = 51;
            this.Dgr_Lager.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_Lager.RowTemplate.Height = 24;
            this.Dgr_Lager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_Lager.Size = new System.Drawing.Size(831, 719);
            this.Dgr_Lager.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_show_total);
            this.tabPage3.Controls.Add(this.ComboBox_Month_all);
            this.tabPage3.Controls.Add(this.ComboBox_year_all);
            this.tabPage3.Controls.Add(this.Lbl_Month_total);
            this.tabPage3.Controls.Add(this.Lbl_year_total);
            this.tabPage3.Controls.Add(this.Lbl_Total);
            this.tabPage3.Controls.Add(this.Dgr_Total);
            this.tabPage3.Controls.Add(this.Btn_show_top10);
            this.tabPage3.Controls.Add(this.ComboBox_Month_top10);
            this.tabPage3.Controls.Add(this.ComboBox_year_top10);
            this.tabPage3.Controls.Add(this.Lbl_Month);
            this.tabPage3.Controls.Add(this.Lbl_year);
            this.tabPage3.Controls.Add(this.Lbl_Best_10);
            this.tabPage3.Controls.Add(this.Dgr_Top10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(974, 769);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_show_total
            // 
            this.Btn_show_total.Location = new System.Drawing.Point(524, 362);
            this.Btn_show_total.Name = "Btn_show_total";
            this.Btn_show_total.Size = new System.Drawing.Size(75, 23);
            this.Btn_show_total.TabIndex = 14;
            this.Btn_show_total.Text = "Show";
            this.Btn_show_total.UseVisualStyleBackColor = true;
            this.Btn_show_total.Click += new System.EventHandler(this.Btn_show_total_Click);
            // 
            // ComboBox_Month_all
            // 
            this.ComboBox_Month_all.AutoCompleteCustomSource.AddRange(new string[] {
            "Janiari",
            "Februari",
            "Mars",
            "April",
            "Maj",
            "Juni",
            "Juli",
            "Augusti",
            "September",
            "Oktober",
            "November",
            "December"});
            this.ComboBox_Month_all.DropDownWidth = 110;
            this.ComboBox_Month_all.FormattingEnabled = true;
            this.ComboBox_Month_all.Location = new System.Drawing.Point(392, 362);
            this.ComboBox_Month_all.Name = "ComboBox_Month_all";
            this.ComboBox_Month_all.Size = new System.Drawing.Size(110, 24);
            this.ComboBox_Month_all.TabIndex = 13;
            // 
            // ComboBox_year_all
            // 
            this.ComboBox_year_all.DropDownWidth = 110;
            this.ComboBox_year_all.FormattingEnabled = true;
            this.ComboBox_year_all.Location = new System.Drawing.Point(190, 361);
            this.ComboBox_year_all.Name = "ComboBox_year_all";
            this.ComboBox_year_all.Size = new System.Drawing.Size(110, 24);
            this.ComboBox_year_all.TabIndex = 12;
            // 
            // Lbl_Month_total
            // 
            this.Lbl_Month_total.AutoSize = true;
            this.Lbl_Month_total.Location = new System.Drawing.Point(315, 365);
            this.Lbl_Month_total.Name = "Lbl_Month_total";
            this.Lbl_Month_total.Size = new System.Drawing.Size(55, 17);
            this.Lbl_Month_total.TabIndex = 11;
            this.Lbl_Month_total.Text = "Månad:";
            // 
            // Lbl_year_total
            // 
            this.Lbl_year_total.AutoSize = true;
            this.Lbl_year_total.Location = new System.Drawing.Point(161, 365);
            this.Lbl_year_total.Name = "Lbl_year_total";
            this.Lbl_year_total.Size = new System.Drawing.Size(26, 17);
            this.Lbl_year_total.TabIndex = 10;
            this.Lbl_year_total.Text = "År:";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(23, 364);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(117, 17);
            this.Lbl_Total.TabIndex = 9;
            this.Lbl_Total.Text = "Total antal sålda:";
            // 
            // Dgr_Total
            // 
            this.Dgr_Total.AllowUserToAddRows = false;
            this.Dgr_Total.AllowUserToDeleteRows = false;
            this.Dgr_Total.AllowUserToResizeColumns = false;
            this.Dgr_Total.AllowUserToResizeRows = false;
            this.Dgr_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_Total.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_Total.Location = new System.Drawing.Point(8, 397);
            this.Dgr_Total.Name = "Dgr_Total";
            this.Dgr_Total.ReadOnly = true;
            this.Dgr_Total.RowHeadersWidth = 51;
            this.Dgr_Total.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_Total.RowTemplate.Height = 24;
            this.Dgr_Total.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_Total.Size = new System.Drawing.Size(934, 344);
            this.Dgr_Total.TabIndex = 8;
            // 
            // Btn_show_top10
            // 
            this.Btn_show_top10.Location = new System.Drawing.Point(524, 15);
            this.Btn_show_top10.Name = "Btn_show_top10";
            this.Btn_show_top10.Size = new System.Drawing.Size(75, 23);
            this.Btn_show_top10.TabIndex = 7;
            this.Btn_show_top10.Text = "Show";
            this.Btn_show_top10.UseVisualStyleBackColor = true;
            this.Btn_show_top10.Click += new System.EventHandler(this.Btn_show_top10_Click);
            // 
            // ComboBox_Month_top10
            // 
            this.ComboBox_Month_top10.AutoCompleteCustomSource.AddRange(new string[] {
            "Janiari",
            "Februari",
            "Mars",
            "April",
            "Maj",
            "Juni",
            "Juli",
            "Augusti",
            "September",
            "Oktober",
            "November",
            "December"});
            this.ComboBox_Month_top10.DropDownWidth = 110;
            this.ComboBox_Month_top10.FormattingEnabled = true;
            this.ComboBox_Month_top10.Location = new System.Drawing.Point(392, 13);
            this.ComboBox_Month_top10.Name = "ComboBox_Month_top10";
            this.ComboBox_Month_top10.Size = new System.Drawing.Size(110, 24);
            this.ComboBox_Month_top10.TabIndex = 6;
            // 
            // ComboBox_year_top10
            // 
            this.ComboBox_year_top10.DropDownWidth = 110;
            this.ComboBox_year_top10.FormattingEnabled = true;
            this.ComboBox_year_top10.Location = new System.Drawing.Point(190, 13);
            this.ComboBox_year_top10.Name = "ComboBox_year_top10";
            this.ComboBox_year_top10.Size = new System.Drawing.Size(110, 24);
            this.ComboBox_year_top10.TabIndex = 5;
            // 
            // Lbl_Month
            // 
            this.Lbl_Month.AutoSize = true;
            this.Lbl_Month.Location = new System.Drawing.Point(315, 18);
            this.Lbl_Month.Name = "Lbl_Month";
            this.Lbl_Month.Size = new System.Drawing.Size(55, 17);
            this.Lbl_Month.TabIndex = 4;
            this.Lbl_Month.Text = "Månad:";
            // 
            // Lbl_year
            // 
            this.Lbl_year.AutoSize = true;
            this.Lbl_year.Location = new System.Drawing.Point(161, 18);
            this.Lbl_year.Name = "Lbl_year";
            this.Lbl_year.Size = new System.Drawing.Size(26, 17);
            this.Lbl_year.TabIndex = 2;
            this.Lbl_year.Text = "År:";
            // 
            // Lbl_Best_10
            // 
            this.Lbl_Best_10.AutoSize = true;
            this.Lbl_Best_10.Location = new System.Drawing.Point(23, 22);
            this.Lbl_Best_10.Name = "Lbl_Best_10";
            this.Lbl_Best_10.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Best_10.TabIndex = 1;
            this.Lbl_Best_10.Text = "Top 10:";
            // 
            // Dgr_Top10
            // 
            this.Dgr_Top10.AllowUserToAddRows = false;
            this.Dgr_Top10.AllowUserToDeleteRows = false;
            this.Dgr_Top10.AllowUserToResizeColumns = false;
            this.Dgr_Top10.AllowUserToResizeRows = false;
            this.Dgr_Top10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_Top10.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgr_Top10.Location = new System.Drawing.Point(8, 49);
            this.Dgr_Top10.MultiSelect = false;
            this.Dgr_Top10.Name = "Dgr_Top10";
            this.Dgr_Top10.ReadOnly = true;
            this.Dgr_Top10.RowHeadersWidth = 51;
            this.Dgr_Top10.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgr_Top10.RowTemplate.Height = 24;
            this.Dgr_Top10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgr_Top10.Size = new System.Drawing.Size(934, 289);
            this.Dgr_Top10.TabIndex = 0;
            // 
            // Btn_Export
            // 
            this.Btn_Export.Location = new System.Drawing.Point(450, 9);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(132, 45);
            this.Btn_Export.TabIndex = 23;
            this.Btn_Export.Text = "Exportera Produktlistan";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // Btn_Import
            // 
            this.Btn_Import.Location = new System.Drawing.Point(600, 9);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(132, 45);
            this.Btn_Import.TabIndex = 24;
            this.Btn_Import.Text = "Importera Produktlistan";
            this.Btn_Import.UseVisualStyleBackColor = true;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // MainForm_Mediabutik_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 798);
            this.Controls.Add(this.Kassa_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1000, 845);
            this.Name = "MainForm_Mediabutik_1";
            this.Text = "Mediabutik_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Mediabutik_1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Mediabutik_1_Load);
            this.Kassa_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_retur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_kundkorg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_kassa_varor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Lager)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_Top10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Kassa_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgr_kassa_varor;
        private System.Windows.Forms.DataGridView Dgr_kundkorg;
        private System.Windows.Forms.Button Btn_Till_kundkorg;
        private System.Windows.Forms.Button Btn_tabort;
        private System.Windows.Forms.Button Btn_addera;
        private System.Windows.Forms.DataGridView Dgr_Lager;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox TextBox_TypeSearch;
        private System.Windows.Forms.TextBox TextBox_NameSearch;
        private System.Windows.Forms.Button Btn_Rensa_korg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Namn;
        private System.Windows.Forms.Label Label_kundkorg;
        private System.Windows.Forms.Button Btn_Retur;
        private System.Windows.Forms.DataGridView Dgr_retur;
        private System.Windows.Forms.Label Label_Retur;
        private System.Windows.Forms.Button Btn_Nyprod;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_retur_id;
        private System.Windows.Forms.TextBox Textbox_kvitto_nr;
        private System.Windows.Forms.Button Btn_Ladda_retur;
        private System.Windows.Forms.Button Btn_Kop;
        private System.Windows.Forms.Button Btn_Skriv_kvitto;
        private System.Windows.Forms.DataGridView Dgr_Top10;
        private System.Windows.Forms.Label Lbl_Best_10;
        private System.Windows.Forms.Label Lbl_year;
        private System.Windows.Forms.Button Btn_show_top10;
        private System.Windows.Forms.ComboBox ComboBox_Month_top10;
        private System.Windows.Forms.ComboBox ComboBox_year_top10;
        private System.Windows.Forms.Label Lbl_Month;
        private System.Windows.Forms.Button Btn_show_total;
        private System.Windows.Forms.ComboBox ComboBox_Month_all;
        private System.Windows.Forms.ComboBox ComboBox_year_all;
        private System.Windows.Forms.Label Lbl_Month_total;
        private System.Windows.Forms.Label Lbl_year_total;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.DataGridView Dgr_Total;
        private System.Windows.Forms.Button Btn_tabort_produkt;
        private System.Windows.Forms.Button Btn_Retur_Klar;
        private System.Windows.Forms.Button Btn_Export;
        private System.Windows.Forms.Button Btn_Import;
    }
}

