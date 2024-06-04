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

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_so1.Text = "";
            txt_so2.Text = "";
            txt_kq.Text = "";
            txt_so1.Focus();    // Đặt con trỏ về ô text số 1
        }

        private void btn_TinhHieu_Click(object sender, EventArgs e)
        {
            double so1, so2, hieu;
            so1 = Convert.ToDouble(txt_so1.Text);
            so2 = Convert.ToDouble(txt_so2.Text);

            hieu = so1 - so2;
            txt_kq.Text = hieu.ToString();
        }

        private void btn_TinhTich_Click(object sender, EventArgs e)
        {
            double so1, so2, tich;
            so1 = Convert.ToDouble(txt_so1.Text);
            so2 = Convert.ToDouble(txt_so2.Text);

            tich = so1 * so2;
            txt_kq.Text = tich.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1, so2, thuong;
            so1 = Convert.ToDouble(txt_so1.Text);
            so2 = Convert.ToDouble(txt_so2.Text);

            thuong = so1 / so2;
            txt_kq.Text = thuong.ToString();
        }
    }
}
