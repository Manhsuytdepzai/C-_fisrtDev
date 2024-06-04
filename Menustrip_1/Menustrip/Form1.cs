using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menustrip
{
    public partial class frmFormChinh : Form
    {
        public frmFormChinh()
        {
            InitializeComponent();
        }

        private void mởForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForm2 f2 = new frmForm2();
            f2.Show();
            //
            //
        }

        private void mởForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForm3 f3 = new frmForm3();
            f3.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
