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
    public partial class Dialog_ja_nej : Form
    {
        public Dialog_ja_nej()
        {
            InitializeComponent();
        }

        private void Btn_Ja_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void Btn_Nej_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}
