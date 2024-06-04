using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DanhSachKhachHang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        // Khai báo các biến toàn cục sử dụng chung
        SqlConnection con1;
        SqlCommand cmd1;
        SqlDataReader reader1;


        void ketNoiSQLServer()
        {
            // Tạo chuỗi kết nối
            string str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True";

            // Tạo kết nối
            con1 = new SqlConnection(str_con);

            // Mở kết nối
            con1.Open();

        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void taiDuLieuTuSQLServer()
        {
            ketNoiSQLServer();  

            string str_tai = "Select * From KhachHang";

            // Tạo đối tượng thực thi
            cmd1 = new SqlCommand();
            cmd1.Connection = con1;
            cmd1.CommandText = str_tai;

            // Đọc dữ liệu
            reader1 = cmd1.ExecuteReader();


            // Đọc dữ liệu, đưa lên ListView
            while(reader1.Read())
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = reader1[0].ToString();
                item1.SubItems.Add(reader1[1].ToString());
                item1.SubItems.Add(reader1[2].ToString());
                item1.SubItems.Add(reader1[3].ToString());
                item1.SubItems.Add(reader1[4].ToString());

                lvDanhSachKhachHang.Items.Add(item1);
            }

            // Đóng kết nối
            con1.Close();
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lvDanhSachKhachHang.Items.Clear();
            taiDuLieuTuSQLServer();
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void lvDanhSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lvDanhSachKhachHang.SelectedItems.Count;
            // i = -1 ứng với không chọn,       1,2,3,4
            if(i > 0)
            {
                txtMaKhachHang.Text = lvDanhSachKhachHang.SelectedItems[0].SubItems[0].Text;
                txtHoTen.Text = lvDanhSachKhachHang.SelectedItems[0].SubItems[1].Text;
                cboGioiTinh.Text = lvDanhSachKhachHang.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lvDanhSachKhachHang.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lvDanhSachKhachHang.SelectedItems[0].SubItems[4].Text;
            }

            else
            {
                txtMaKhachHang.Clear();                 // txtMaKhachHang.Text = "";
                txtHoTen.Clear();
                cboGioiTinh.ResetText();
                txtDiaChi.Clear();
                txtDienThoai.Clear();
            }
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void themDuLieu()
        {
            ketNoiSQLServer();

            string str_them = "insert into KhachHang values ";
            str_them = str_them + "(@ma_kh, @ten_kh, @gioi_tinh, @dia_chi, @dien_thoai)";


            // Tạo đối tượng thực thi
            cmd1 = new SqlCommand(str_them, con1);

            // Gán các giá trị cho các tham số lấy từ các ô TextBox, ComboBox
            cmd1.Parameters.AddWithValue(@"ma_kh", txtMaKhachHang.Text);
            cmd1.Parameters.AddWithValue(@"ten_kh", txtHoTen.Text);
            cmd1.Parameters.AddWithValue(@"gioi_tinh", cboGioiTinh.Text);
            cmd1.Parameters.AddWithValue(@"dia_chi", txtDiaChi.Text);
            cmd1.Parameters.AddWithValue(@"dien_thoai", txtDienThoai.Text);


            // Thực thi thêm dữ liệu
            int so_luong;
            so_luong = cmd1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");

            // Đóng kết nối
            con1.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            themDuLieu();
            lvDanhSachKhachHang.Items.Clear();
            taiDuLieuTuSQLServer();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void capNhatDuLieu()
        {
            ketNoiSQLServer();

            string str_sua = "update KhachHang set ";
            str_sua = str_sua + "TenKH = @ten_kh, GioiTinh = @gioi_tinh, DiaChi = @dia_chi, DienThoai = @dien_thoai "
                            + "where MaKH = @ma_kh";


            // Tạo đối tượng thực thi
            cmd1 = new SqlCommand(str_sua, con1);

            // Gán các giá trị cho các tham số lấy từ các ô TextBox, ComboBox
            cmd1.Parameters.AddWithValue(@"ma_kh", txtMaKhachHang.Text);
            cmd1.Parameters.AddWithValue(@"ten_kh", txtHoTen.Text);
            cmd1.Parameters.AddWithValue(@"gioi_tinh", cboGioiTinh.Text);
            cmd1.Parameters.AddWithValue(@"dia_chi", txtDiaChi.Text);
            cmd1.Parameters.AddWithValue(@"dien_thoai", txtDienThoai.Text);


            // Thực thi cập nhật dữ liệu
            int so_luong;
            so_luong = cmd1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");

            // Đóng kết nối
            con1.Close();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhatDuLieu();
            lvDanhSachKhachHang.Items.Clear();
            taiDuLieuTuSQLServer();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void xoaDuLieu()
        {
            ketNoiSQLServer();

            string str_xoa = "delete KhachHang where MaKH = @ma_kh";

            // Tạo đối tượng thực thi
            cmd1 = new SqlCommand(str_xoa, con1);

            // Gán  giá trị cho tham số @ma_kh lấy từ các ô TextBox
            cmd1.Parameters.AddWithValue(@"ma_kh", txtMaKhachHang.Text);


            // Thực thi xóa dữ liệu
            int so_luong;
            so_luong = cmd1.ExecuteNonQuery();
            if (so_luong > 0)
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");

            // Đóng kết nối
            con1.Close();

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
            lvDanhSachKhachHang.Items.Clear();
            taiDuLieuTuSQLServer();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem f1 = new frmTimKiem();
            f1.ShowDialog();
        }

    }
}
