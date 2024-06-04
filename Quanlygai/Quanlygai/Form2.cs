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

namespace Quanlygai
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string fileContent)
        {
            InitializeComponent();
            txt_ht.Text = fileContent;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\mmmma\Documents\Documents\c#\Quanlygai\Quanlygai\tuynhehe.txt";
            string fileContent = File.ReadAllText(filepath);
            Form2 f2 = new Form2(fileContent);
            f2.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_ht.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
