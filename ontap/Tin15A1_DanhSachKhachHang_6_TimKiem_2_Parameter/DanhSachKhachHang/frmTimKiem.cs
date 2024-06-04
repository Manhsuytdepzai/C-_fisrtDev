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

namespace DanhSachKhachHang
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }


        // Khai báo các biến toàn cục sử dụng chung
        SqlConnection con1;
        SqlCommand cmd1;
        SqlDataReader reader1;


        void ketNoiSQLServer()
        {
            // Tạo chuỗi kết nối
            string str_con = @"Data Source=DESKTOP-L3CHJKH;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True";

            // Tạo kết nối
            con1 = new SqlConnection(str_con);

            // Mở kết nối
            con1.Open();

        }

        void timKiemDuLieu()
        {
            ketNoiSQLServer();

            string str_truong;

            if (cboTruong.SelectedIndex == 0)
                str_truong = "MaKH";
            else if (cboTruong.SelectedIndex == 1)
                str_truong = "TenKH";
            else if (cboTruong.SelectedIndex == 2)
                str_truong = "DiaChi";
            else 
                str_truong = "DienThoai"; 
      

            string str_timkiem = "select * From KhachHang where " + str_truong + " LIKE @noi_dung";

            // Tạo đối tượng thực thi
            cmd1 = new SqlCommand();
            cmd1.Connection = con1;
            cmd1.CommandText = str_timkiem;


            // Gán các giá trị cho các tham số lấy từ các ô TextBox, ComboBox
            cmd1.Parameters.AddWithValue(@"noi_dung", "%" + txtNoiDung.Text + "%");
          

            // Đọc dữ liệu
            reader1 = cmd1.ExecuteReader();


            // Đọc dữ liệu, đưa lên ListView
            while (reader1.Read())
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lvDanhSachKhachHang.Items.Clear();
            timKiemDuLieu();
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            lvDanhSachKhachHang.Items.Clear();
            timKiemDuLieu();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}
