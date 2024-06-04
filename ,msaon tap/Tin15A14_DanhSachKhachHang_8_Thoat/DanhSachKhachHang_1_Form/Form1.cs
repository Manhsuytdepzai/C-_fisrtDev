using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        void taikieudulieuSQL()
        {
            //tạo chuỗi kết nối
            string str_con;
            str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True";
            // tạo kết nối

            SqlConnection con1 = new SqlConnection(); ;
            con1.ConnectionString = str_con;
            
            con1.Open();

            // tạo chuỗi truy vấn lấy thông tin kjachs hANG

            string str_tai = "SELECT * FROM KhachHang";

            // tạo đối tượng thực thi
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = str_tai;

            SqlCommand smd2 = new SqlCommand(str_tai, con1);
            SqlDataReader reader;
            reader = smd2.ExecuteReader();

            // đọc dữu liệu đưa lên list view
            while (reader.Read())
            {
                ListViewItem liv1 = new ListViewItem();
                liv1.Text = reader[0].ToString();
                liv1.SubItems.Add(reader[1].ToString());
                liv1.SubItems.Add(reader[2].ToString());
                liv1.SubItems.Add(reader[3].ToString());
                liv1.SubItems.Add(reader[4].ToString());

                lv_DSKhachHang.Items.Add(liv1);


            }
            con1.Close();
        }
        void ketNoi()
        {
            str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True";

            // Tạo kết nối
            con_1 = new SqlConnection(str_con);

            // Mở kết nối
            con_1.Open();
        }

        void thucThi()
        {
            // Tạo đối tượng thực thi
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandType = CommandType.Text;       // Dòng này có thể không viết
            cmd_1.CommandText = str_thucthi;
        }
        /*public void goiDuLieu()
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
        }*/

        private void btn_GoiDuLieu_Click(object sender, EventArgs e)
        {
            //goiDuLieu();
            lv_DSKhachHang.Items.Clear();
            taikieudulieuSQL();
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Hiển thị lên các ô Text khi bấm chọn Item
        private void lv_DSKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < lv_DSKhachHang.SelectedItems.Count; i++)
            {
                txt_MaKhachHang.Text = lv_DSKhachHang.SelectedItems[i].SubItems[0].Text;
                txt_HoTen.Text = lv_DSKhachHang.SelectedItems[i].SubItems[1].Text;
                cbo_GioiTinh.Text = lv_DSKhachHang.SelectedItems[i].SubItems[2].Text;
                txt_DiaChi.Text = lv_DSKhachHang.SelectedItems[i].SubItems[3].Text;
                txt_DienThoai.Text = lv_DSKhachHang.SelectedItems[i].SubItems[4].Text;
            }
        }

        private void cbo_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con_1;
        string str_con;
        string str_thucthi;
        SqlCommand cmd_1, cmd_2;
        SqlDataReader reader_1;
        void suaDuLieu()
        {
            ketNoi();

            // tạo chuỗi thông tin để chèn thêm dữ liệu
            str_thucthi = "update KhachHang set ";
            str_thucthi = str_thucthi + "TenKH = " + "N'" + txt_HoTen.Text + "',"
                                      + "GioiTinh = " + "N'" + cbo_GioiTinh.Text + "',"
                                      + "DiaChi = " + "N'" + txt_DiaChi.Text + "',"
                                      + "DienThoai = " + "N'" + txt_DienThoai.Text + "'"
                                      + "where MaKH = " + "'" + txt_MaKhachHang.Text + "'";

            thucThi();

            // Thực thi
            int so_luong = cmd_1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo");

            con_1.Close();
        }


        private void sua_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            suaDuLieu();
            ketNoi();
        }
    }
}
