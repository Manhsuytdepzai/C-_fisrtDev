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


        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection con_1;
        string str_con;
        string str_thucthi;
        SqlCommand cmd_1, cmd_2;
        SqlDataReader reader_1;


        void ketNoi()
        {
            str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True;Encrypt=True";

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

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void taiDuLieuTuSQLServer()
        {
            ketNoi();

            // tạo chuỗi truy vấn lấy thông tin bảng khách hàng
            str_thucthi = "Select * From KhachHang";

            thucThi();

            // Tạo đối tượng đọc dữ liệu
            reader_1 = cmd_1.ExecuteReader();


            // Đọc dữ liệu, đưa lên ListView
            while (reader_1.Read())
            {
                ListViewItem lvi_1 = new ListViewItem();
                lvi_1.Text = reader_1[0].ToString();
                lvi_1.SubItems.Add(reader_1[1].ToString());
                lvi_1.SubItems.Add(reader_1[2].ToString());
                lvi_1.SubItems.Add(reader_1[3].ToString());
                lvi_1.SubItems.Add(reader_1[4].ToString());

                lv_DSKhachHang.Items.Add(lvi_1);
            }
        
            // Đóng kết nối
            con_1.Close();
        
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            taiDuLieuTuSQLServer();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void themDuLieu()
        {
            ketNoi();
            // tạo chuỗi thông tin để chèn thêm dữ liệu
             str_thucthi = "insert into KhachHang values ";
            str_thucthi = str_thucthi + "(" + "'" + txt_MaKhachHang.Text + "'" + ","
                                + "N'" + txt_HoTen.Text + "'" + ","
                                + "N'" + cbo_GioiTinh.Text + "'" + ","
                                + "N'" + txt_DiaChi.Text + "'" + ","
                                + "'" + txt_DienThoai.Text + "'" + ")";

            thucThi();

            // Thực thi
            int so_luong = cmd_1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Thêm dữ liệu thành công", "Thông Báo");

            con_1.Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            themDuLieu();
            taiDuLieuTuSQLServer();
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void suaDuLieu()
        {
            ketNoi();

            // tạo chuỗi thông tin để sửa dữ liệu
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            suaDuLieu();
            taiDuLieuTuSQLServer();
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void xoaDuLieu()
        {
            ketNoi();

            // tạo chuỗi thông tin để xóa dữ liệu
            str_thucthi = "delete from KhachHang where MaKH = " 
                            + "'" + txt_MaKhachHang.Text + "'";

            thucThi();

            // Thực thi
            int so_luong = cmd_1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo");

            con_1.Close();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            xoaDuLieu();
            taiDuLieuTuSQLServer();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void timKiemDuLieu()
        {
            ketNoi();

            // tạo chuỗi truy vấn lấy thông tin bảng khách hàng
            str_thucthi = "Select * From KhachHang where MaKH LIKE "
                            + "'%" + txt_MaKhachHang.Text + "%'";

            thucThi();

            // Tạo đối tượng đọc dữ liệu
            reader_1 = cmd_1.ExecuteReader();


            // Đọc dữ liệu, đưa lên ListView
            while (reader_1.Read())
            {
                ListViewItem lvi_1 = new ListViewItem();
                lvi_1.Text = reader_1[0].ToString();
                lvi_1.SubItems.Add(reader_1[1].ToString());
                lvi_1.SubItems.Add(reader_1[2].ToString());
                lvi_1.SubItems.Add(reader_1[3].ToString());
                lvi_1.SubItems.Add(reader_1[4].ToString());

                lv_DSKhachHang.Items.Add(lvi_1);
            }

            // Đóng kết nối
            con_1.Close();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            timKiemDuLieu();
        }

        private void txt_MaKhachHang_TextChanged(object sender, EventArgs e)
        {
            //lv_DSKhachHang.Items.Clear();
            //timKiemDuLieu();
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void lv_DSKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_DSKhachHang.SelectedItems.Count > 0)
            {
                txt_MaKhachHang.Text = lv_DSKhachHang.SelectedItems[0].SubItems[0].Text;
                txt_HoTen.Text = lv_DSKhachHang.SelectedItems[0].SubItems[1].Text;
                cbo_GioiTinh.Text = lv_DSKhachHang.SelectedItems[0].SubItems[2].Text;
                txt_DiaChi.Text = lv_DSKhachHang.SelectedItems[0].SubItems[3].Text;
                txt_DienThoai.Text = lv_DSKhachHang.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                txt_MaKhachHang.Clear();        // txt_MaKhachHang.Text = "";
                txt_HoTen.Clear();
                cbo_GioiTinh.ResetText();
                txt_DiaChi.Clear();
                txt_DienThoai.Clear();
            }
        }
    }
}
