namespace Mediabutik_Lab4_1
{
    partial class Dialog_ja_nej
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
            this.Lbl_ja_nej = new System.Windows.Forms.Label();
            this.Btn_Ja = new System.Windows.Forms.Button();
            this.Btn_Nej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ja_nej
            // 
            this.Lbl_ja_nej.AutoSize = true;
            this.Lbl_ja_nej.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ja_nej.Location = new System.Drawing.Point(12, 22);
            this.Lbl_ja_nej.Name = "Lbl_ja_nej";
            this.Lbl_ja_nej.Size = new System.Drawing.Size(430, 58);
            this.Lbl_ja_nej.TabIndex = 0;
            this.Lbl_ja_nej.Text = "Vill du ta bort produkten ur sortimentet, \r\ntrots att lagersaldot är inte tomt?";
            // 
            // Btn_Ja
            // 
            this.Btn_Ja.Location = new System.Drawing.Point(37, 103);
            this.Btn_Ja.Name = "Btn_Ja";
            this.Btn_Ja.Size = new System.Drawing.Size(115, 46);
            this.Btn_Ja.TabIndex = 1;
            this.Btn_Ja.Text = "Ja";
            this.Btn_Ja.UseVisualStyleBackColor = true;
            this.Btn_Ja.Click += new System.EventHandler(this.Btn_Ja_Click);
            // 
            // Btn_Nej
            // 
            this.Btn_Nej.Location = new System.Drawing.Point(306, 103);
            this.Btn_Nej.Name = "Btn_Nej";
            this.Btn_Nej.Size = new System.Drawing.Size(115, 46);
            this.Btn_Nej.TabIndex = 2;
            this.Btn_Nej.Text = "Nej";
            this.Btn_Nej.UseVisualStyleBackColor = true;
            this.Btn_Nej.Click += new System.EventHandler(this.Btn_Nej_Click);
            // 
            // Dialog_ja_nej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 184);
            this.Controls.Add(this.Btn_Nej);
            this.Controls.Add(this.Btn_Ja);
            this.Controls.Add(this.Lbl_ja_nej);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_ja_nej";
            this.Text = "Ta bort produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ja_nej;
        private System.Windows.Forms.Button Btn_Ja;
        private System.Windows.Forms.Button Btn_Nej;
    }
}