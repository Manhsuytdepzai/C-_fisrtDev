using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TinhTong_Click(object sender, EventArgs e)
        {
            double so1, so2, tong;
            so1 = Convert.ToDouble(txt_so1.Text);
            so2 = Convert.ToDouble(txt_so2.Text);

            tong = so1 + so2;
            // In kết quả
            txt_kq.Text = tong.ToString();
        }
    }
}
