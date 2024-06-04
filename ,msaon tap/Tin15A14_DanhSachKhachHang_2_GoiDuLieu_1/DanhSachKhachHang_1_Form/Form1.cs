using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachKhachHang_1_Form
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            
        }

        public void goiDuLieu()
        {
            // Xóa dữ liệu cũ trên ListView
            lv_DSKhachHang.Items.Clear();

            ListViewItem lvi_1 = new ListViewItem();
            lvi_1.Text = "KH_2024_1302";
            lvi_1.SubItems.Add("Nguyễn Văn An");
            lvi_1.SubItems.Add("Nam");
            lvi_1.SubItems.Add("Ngõ 218, Lĩnh Nam");
            lvi_1.SubItems.Add("0912345678");
            lv_DSKhachHang.Items.Add(lvi_1);

            ListViewItem lvi_2 = new ListViewItem();
            lvi_2.Text = "KH_2023_1234";
            lvi_2.SubItems.Add("Hoàng Thùy Linh");
            lvi_2.SubItems.Add("Nữ");
            lvi_2.SubItems.Add("Số nhà 15, Ngõ 4, Tam Trinh");
            lvi_2.SubItems.Add("0988444555");
            lv_DSKhachHang.Items.Add(lvi_2);
        }

        private void btn_GoiDuLieu_Click(object sender, EventArgs e)
        {
            goiDuLieu();
        }
    }
}
