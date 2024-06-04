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
        void taikieudulieuSQL()
        {
            //tạo chuỗi kết nối
            string str_con;
            str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=QuanLyBanHang_5.2024_2;Integrated Security=True";
            // tạo kết nối

            SqlConnection con1;
            con1 = new SqlConnection(str_con);

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
        private void btn_themDuLieu_Click(object sender, EventArgs e)
        {
            lv_DSKhachHang.Items.Clear();
            taikieudulieuSQL();
        }

        /*public void goiDuLieu()
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
        }*/
    }
}
