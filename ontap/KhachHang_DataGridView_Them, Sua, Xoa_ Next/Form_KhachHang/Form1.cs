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

namespace Form_KhachHang
{
    public partial class frm_DanhSachKhachHang : Form
    {
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
        }


        private void frm_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
           
        }

        SqlConnection con_1;
        SqlCommand cmd_1, cmd_2;


        void ketNoi()
        {
            string str_con;
            str_con = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QuanLyBanHang_2024_v3.mdf;Integrated Security=True;Connect Timeout=30";

            // Khởi tạo 1 kết nối
            con_1 = new SqlConnection(str_con);

            // Mở kết nối
            con_1.Open();
        }

        void taiDuLieu_Nguon_Toi_Luoi()
        {
            ketNoi();

            // Tạo chuỗi tải dữ liệu từ DataSource
            string str_tai = "select * from KhachHang";

            // Tạo đối tượng thi hành lệnh
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandText = str_tai;

            // tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            DataSet ds1 = new DataSet();
            DataTable dtKhachHang = new DataTable();

            // Lấy dữ liệu từ nguồn, đưa vào bảng dtKhachHang
            sqla1.Fill(dtKhachHang);

            gridDSKhachHang.DataSource = dtKhachHang;

            con_1.Close();
        }


        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            taiDuLieu_Nguon_Toi_Luoi();
        }


        private void gridDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridDSKhachHang.CurrentRow.Index;
            txt_MaKhachHang.Text = gridDSKhachHang.Rows[i].Cells[0].Value.ToString();
            txt_HoTen.Text = gridDSKhachHang.Rows[i].Cells[1].Value.ToString();
            cbo_GioiTinh.Text = gridDSKhachHang.Rows[i].Cells[2].Value.ToString();
            txt_DiaChi.Text = gridDSKhachHang.Rows[i].Cells[3].Value.ToString();
            txt_DienThoai.Text = gridDSKhachHang.Rows[i].Cells[4].Value.ToString();
        }

        

        void themDuLieu()
        {
            ketNoi();

            // Tạo chuỗi tải dữ liệu từ DataSource
            string str_tai = "select * from KhachHang";

            // Tạo đối tượng thi hành lệnh
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandText = str_tai;

            // tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            DataSet ds1 = new DataSet();
            DataTable dtKhachHang = new DataTable();

            // Lấy dữ liệu từ nguồn, đưa vào bảng dtKhachHang
            sqla1.Fill(dtKhachHang);

            // Đọc dữ liệu được thêm từ các ô ComboBox, TextBox trên Form
            DataRow dr1 = dtKhachHang.NewRow();
            dr1[0] = txt_MaKhachHang.Text;
            dr1[1] = txt_HoTen.Text;
            dr1[2] = cbo_GioiTinh.Text;
            dr1[3] = txt_DiaChi.Text;
            dr1[4] = txt_DienThoai.Text;

            dtKhachHang.Rows.Add(dr1);

            string str_them = "insert into KhachHang values (@ma_kh, @ten_kh, @gioi, @dia_chi, @dien_thoai)";

            // Tạo đối tượng thực thi trung chuyển
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con_1;
            cmd2.CommandText = str_them;

            cmd2.Parameters.AddWithValue(@"ma_kh", dr1[0]);
            cmd2.Parameters.AddWithValue(@"ten_kh", dr1[1]);
            cmd2.Parameters.AddWithValue(@"gioi", dr1[2]);
            cmd2.Parameters.AddWithValue(@"dia_chi", dr1[3]);
            cmd2.Parameters.AddWithValue(@"dien_thoai", dr1[4]);

            SqlDataAdapter sqla2 = new SqlDataAdapter();
            sqla2.InsertCommand = cmd2;

            int so_luong;
            so_luong = sqla2.Update(dtKhachHang);

            if (so_luong > 0)
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            themDuLieu();
        }


        void suaDuLieu()
        {
            ketNoi();

            // Tạo chuỗi tải dữ liệu từ DataSource
            string str_tai = "select * from KhachHang";

            // Tạo đối tượng thi hành lệnh
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandText = str_tai;

            // tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            // DataSet ds1 = new DataSet();
            DataTable dtKhachHang = new DataTable();

            // Lấy dữ liệu từ nguồn, đưa vào bảng dtKhachHang
            sqla1.Fill(dtKhachHang);

            gridDSKhachHang.DataSource = dtKhachHang;

            // Gán dữ liệu được sửa từ các ô ComboBox, TextBox trên Form
            int i = gridDSKhachHang.CurrentRow.Index;
            
            DataRow dr1 = dtKhachHang.Rows[i];
           // dr1[0] = txt_MaKhachHang.Text;
            dr1[1] = txt_HoTen.Text;
            dr1[2] = cbo_GioiTinh.Text;
            dr1[3] = txt_DiaChi.Text;
            dr1[4] = txt_DienThoai.Text;


            string str_sua = "update KhachHang "
                        + "set TenKH = @ten_kh, GioiTinh = @gioi, DiaChi = @dia_chi, DienThoai = @dien_thoai"
                        + " where MaKH = @ma_kh";

            // Tạo đối tượng thực thi trung chuyển
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con_1;
            cmd2.CommandText = str_sua;

            cmd2.Parameters.AddWithValue(@"ma_kh", dr1[0]);
            cmd2.Parameters.AddWithValue(@"ten_kh", dr1[1]);
            cmd2.Parameters.AddWithValue(@"gioi", dr1[2]);
            cmd2.Parameters.AddWithValue(@"dia_chi", dr1[3]);
            cmd2.Parameters.AddWithValue(@"dien_thoai", dr1[4]);

            SqlDataAdapter sqla2 = new SqlDataAdapter();
            sqla2.UpdateCommand = cmd2;

            int so_luong;
            so_luong = sqla2.Update(dtKhachHang);

            if (so_luong > 0)
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            suaDuLieu();
        }

        void xoaDuLieu()
        {
            ketNoi();

            // Tạo chuỗi tải dữ liệu từ DataSource
            string str_tai = "select * from KhachHang";

            // Tạo đối tượng thi hành lệnh
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandText = str_tai;

            // tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            DataSet ds1 = new DataSet();
            DataTable dtKhachHang = new DataTable();

            // Lấy dữ liệu từ nguồn, đưa vào bảng dtKhachHang
            sqla1.Fill(dtKhachHang);

            // Xóa dữ liệu được chỉ định từ các ô ComboBox, TextBox trên Form
            dtKhachHang.Rows[0].Delete();


            string str_xoa = "delete KhachHang where MaKH = @ma_kh";

            // Tạo đối tượng thực thi trung chuyển
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con_1;
            cmd2.CommandText = str_xoa;

            cmd2.Parameters.AddWithValue(@"ma_kh", txt_MaKhachHang.Text);

            SqlDataAdapter sqla2 = new SqlDataAdapter();
            sqla2.DeleteCommand = cmd2;

            int so_luong;
            so_luong = sqla2.Update(dtKhachHang);

            if (so_luong > 0)
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
            taiDuLieu_Nguon_Toi_Luoi();
        }
    }
}
