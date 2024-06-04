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


        void ketNoi()
        {
            str_con = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmmma\Documents\Documents\c#\ontap\Tin15A14_DanhSachKhachHang_DataGridView_3_Them_C2_Builder\DanhSachKhachHang_1_Form\bin\Debug\QuanLyBanHang_2024_v3.mdf;Integrated Security=True;Connect Timeout=30";

            // Tạo kết nối
            con_1 = new SqlConnection(str_con);

            // Mở kết nối
            con_1.Open();
        }

        

        void thucThi(string str_thucthi)
        {
            // Tạo đối tượng thực thi
            cmd_1 = new SqlCommand();
            cmd_1.Connection = con_1;
            cmd_1.CommandText = str_thucthi;
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        void taiDuLieu_tu_Server_toi_Luoi()
        {
            // Gọi hàm kết nối
            ketNoi();

            // tạo chuỗi tải dữ liệu
            string str_tai = "Select * From KhachHang";

            // Tạo đối tượng thực thi
            thucThi(str_tai);

            //Tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            // Tạo bộ dữ liệu lưu trữ trung chuyển
            DataSet ds1 = new DataSet();

            // tạo 1 bảng mới trong ds1
            DataTable dtKhachHang = new DataTable();

            // Đổ dữ liệu từ nguồn vào bảng dtKhachHang trong DataSet
            sqla1.Fill(dtKhachHang);

            // Gắn dữ liệu từ bảng dtKhachHang vào lưới
            gridDSKhachHang.DataSource = dtKhachHang;

            con_1.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            taiDuLieu_tu_Server_toi_Luoi();
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void gridDSKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gridDSKhachHang.CurrentRow.Index;
            txt_MaKhachHang.Text = gridDSKhachHang.Rows[i].Cells[0].Value.ToString();
            txt_HoTen.Text = gridDSKhachHang.Rows[i].Cells[1].Value.ToString();
            cbo_GioiTinh.Text = gridDSKhachHang.Rows[i].Cells[2].Value.ToString();
            txt_DiaChi.Text = gridDSKhachHang.Rows[i].Cells[3].Value.ToString();
            txt_DienThoai.Text = gridDSKhachHang.Rows[i].Cells[4].Value.ToString();
        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        void themDuLieu()
        {
            // Gọi hàm kết nối
            ketNoi();

            // tạo chuỗi tải dữ liệu
            string str_tai = "Select * From KhachHang";

            // Tạo đối tượng thực thi
            thucThi(str_tai);

            //Tạo đối tượng thực thi trung gian
            SqlDataAdapter sqla1 = new SqlDataAdapter();
            sqla1.SelectCommand = cmd_1;

            // Tạo bộ dữ liệu lưu trữ trung chuyển
            DataSet ds1 = new DataSet();

            // tạo 1 bảng mới trong ds1
            DataTable dtKhachHang = new DataTable();

            // Đổ dữ liệu từ nguồn vào bảng dtKhachHang trong DataSet
            sqla1.Fill(dtKhachHang);

            // Gắn dữ liệu từ bảng dtKhachHang vào lưới
            gridDSKhachHang.DataSource = dtKhachHang;


            // Đọc dữ liệu tại các ô TextBox, ComboBox. gán vào bảng dtKhachhang của ds1
            DataRow dr1 = dtKhachHang.NewRow();
            dr1[0] = txt_MaKhachHang.Text;      // dr1["MaKH"] = txt_MaKhachHang.Text;
            dr1[1] = txt_HoTen.Text;
            dr1[2] = cbo_GioiTinh.Text;
            dr1[3] = txt_DiaChi.Text;
            dr1[4] = txt_DienThoai.Text;

            dtKhachHang.Rows.Add(dr1);

            SqlCommandBuilder builder1 = new SqlCommandBuilder();
            builder1.DataAdapter = sqla1;

            int so_luong;
            so_luong = sqla1.Update(dtKhachHang);

            if (so_luong > 0)
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themDuLieu();
        }

        


    }
}
