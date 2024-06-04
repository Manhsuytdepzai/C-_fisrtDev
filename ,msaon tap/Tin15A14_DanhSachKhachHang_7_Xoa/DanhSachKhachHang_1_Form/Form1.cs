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
            txt_MaKhachHang.Focus();
        }

        public void goiDuLieu()
        {
            // Xóa dữ liệu cũ trên ListView
            lv_DSKhachHang.Items.Clear();

            for(int i = 0; i < 5; i++)
            {
                ListViewItem lvi_1 = new ListViewItem();
                lvi_1.Text = "KH_2024_125" + (i + 1).ToString();
                lvi_1.SubItems.Add("Khách hàng" + (i + 1).ToString());

                string gioi_tinh = "";
                if (i % 2 == 0)
                    gioi_tinh = "Nam";
                else
                    gioi_tinh = "Nữ";
                lvi_1.SubItems.Add(gioi_tinh);

                lvi_1.SubItems.Add("Ngõ 4, đường Tam Trinh");
                lvi_1.SubItems.Add("091235744" + (i + 3).ToString());
                lv_DSKhachHang.Items.Add(lvi_1);
                txt_MaKhachHang.Focus();
            }
        }

        private void btn_GoiDuLieu_Click(object sender, EventArgs e)
        {
            goiDuLieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem lvi_1 = new ListViewItem();
            lvi_1.Text = txt_MaKhachHang.Text;
            lvi_1.SubItems.Add(txt_HoTen.Text);
            lvi_1.SubItems.Add(cbo_GioiTinh.Text);
            lvi_1.SubItems.Add(txt_DiaChi.Text);
            lvi_1.SubItems.Add(txt_DienThoai.Text);

            lv_DSKhachHang.Items.Add(lvi_1);

            txt_MaKhachHang.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();

            txt_MaKhachHang.Focus();
        }

        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Remove(lv_DSKhachHang.SelectedItems[0]);
        }
    }
}
