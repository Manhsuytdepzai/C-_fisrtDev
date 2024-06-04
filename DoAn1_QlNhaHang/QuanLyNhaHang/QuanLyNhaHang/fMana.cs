using QuanLyNhaHang.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class fMana : Form
    {
        DataProvider provider = new DataProvider(); 
        public fMana()
        {
            InitializeComponent();
            //loadMonAn();
        }
        public void loadMonAn()
        {
            string query = "SELECT * FROM [QL_NhaHang].[dbo].[MonAn]";
            dgv_monAn.DataSource = provider.ExecuteQuery(query);
            dgv_monAn.Columns[0].HeaderText = "Mã món ăn";
            dgv_monAn.Columns[1].HeaderText = "Tên món ăn";
            dgv_monAn.Columns[2].HeaderText = "Giá";
            dgv_monAn.Columns[3].HeaderText = "Mô tả";
            dgv_monAn.Columns[1].Width = 100;
            dgv_monAn.Columns[3].Width = 300;
        }
        private void fMana_Load(object sender, EventArgs e)
        {

        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
           loadMonAn();
        }

        

        private void dgv_monAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_maMonAn.Text = dgv_monAn[0, e.RowIndex].Value.ToString();
            txb_tenMonAn.Text = dgv_monAn[1, e.RowIndex].Value.ToString();
            txb_gia.Text = dgv_monAn[2, e.RowIndex].Value.ToString();
            txb_moTa.Text = dgv_monAn[3, e.RowIndex].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string mma = txb_maMonAn.Text;
            string tma = txb_tenMonAn.Text;
            decimal gia = decimal.Parse(txb_gia.Text);
            string mota = txb_moTa.Text;

            string query = "insert into MonAn(MonAnID,TenMonAn,Gia,MoTa)" +
                            "values ('" + mma+"',N'"+ tma+"','" +gia+"',N'"+mota+"' )";
            dgv_monAn.DataSource = provider.ExecuteNonQuery(query);
            loadMonAn();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string mma = txb_maMonAn.Text;
            string tma = txb_tenMonAn.Text;
            decimal gia = decimal.Parse(txb_gia.Text);
            string mota = txb_moTa.Text;

            string query = "update MonAn set ";
            query += "TenMonAn = N'" + tma + "',";
            query += "Gia = '" + gia + "',";
            query += "MoTa = N'" + mota+ "'";
            query += "Where MonAnID = '" + mma + "'";
            dgv_monAn.DataSource = provider.ExecuteNonQuery(query);
            loadMonAn();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [QL_NhaHang].[dbo].[MonAn] where TenMonAn like N'%" + txb_timKiem.Text+ "%'";
            dgv_monAn.DataSource = provider.ExecuteQuery(query);
            dgv_monAn.Columns[0].HeaderText = "Mã món ăn";
            dgv_monAn.Columns[1].HeaderText = "Tên món ăn";
            dgv_monAn.Columns[2].HeaderText = "Giá";
            dgv_monAn.Columns[3].HeaderText = "Mô tả";
            dgv_monAn.Columns[1].Width = 100;
            dgv_monAn.Columns[3].Width = 300;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string mma = txb_maMonAn.Text;
            string query = $"DELETE MonAn WHERE MonAnID = N'{mma}'";
            dgv_monAn.DataSource = provider.ExecuteNonQuery(query);
            loadMonAn();

            txb_maMonAn.Text = "";
            txb_tenMonAn.Text = "";
            txb_gia.Text = "";
            txb_moTa.Text = "";
        }

        private void ms_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------
        public void loadNhanVien()
        {
            string query = "SELECT * FROM [QL_NhaHang].[dbo].[NhanVien]";
            dgvNhanVien.DataSource = provider.ExecuteQuery(query);
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[4].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Email";
            dgvNhanVien.Columns[6].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[7].HeaderText = "Lương";

        }
        private void btn_themNv_Click(object sender, EventArgs e)
        {
            string query = "insert into NhanVien(NhanVienID,HoTen,GioiTinh,NgaySinh,SoDienThoai,Email,ChucVu,Luong)"
                            + "values ('" + txb_maNv.Text + "',N'" + txb_tenNv.Text + "',N'" + cb_gioiTinh.Text + "',N'" + txb_ngaySinh.Text + "',N'" + txb_sdt.Text + "',N'" + txb_email.Text + "',N'" + txb_chucVu.Text + "',N'" + txt_Luong.Text + "' )";
            dgvNhanVien.DataSource = provider.ExecuteNonQuery(query);
            loadNhanVien();
            txb_maNv.Clear();
            txb_tenNv.Clear();
            cb_gioiTinh.Items.Clear();
            txb_ngaySinh.Clear();
            txb_sdt.Clear();
            txb_email.Clear();
            txb_chucVu.Clear();
            txt_Luong.Clear();
        }

        private void btn_hienNv_Click(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_maNv.Text = dgvNhanVien[0, e.RowIndex].Value.ToString();
            txb_tenNv.Text = dgvNhanVien[1, e.RowIndex].Value.ToString();
            cb_gioiTinh.Text = dgvNhanVien[2, e.RowIndex].Value.ToString();
            txb_ngaySinh.Text = dgvNhanVien[3, e.RowIndex].Value.ToString();
            txb_sdt.Text = dgvNhanVien[4, e.RowIndex].Value.ToString();
            txb_email.Text = dgvNhanVien[5, e.RowIndex].Value.ToString();
            txb_chucVu.Text = dgvNhanVien[6, e.RowIndex].Value.ToString();
            txt_Luong.Text = dgvNhanVien[7, e.RowIndex].Value.ToString();
        }

        private void btn_suaNv_Click(object sender, EventArgs e)
        {
            string query = "update NhanVien set ";    
            query += "HoTen = N'" + txb_tenNv.Text + "',";
            query += "GioiTinh = N'" + cb_gioiTinh.Text + "',";
            query += "NgaySinh = '" + txb_ngaySinh.Text + "',";
            query += "SoDienThoai = N'" + txb_sdt.Text + "',";
            query += "Email = N'" + txb_email.Text + "',";
            query += "ChucVu = N'" + txb_chucVu.Text + "',";
            query += "Luong = N'" + decimal.Parse(txt_Luong.Text) + "'";
            query += "Where NhanVienID = '" + txb_maNv.Text + "'";
            dgvNhanVien.DataSource = provider.ExecuteNonQuery(query);
            loadNhanVien();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dgv_monAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "insert into HoaDon(HoaDonID,NhanVienID,Ngaylap,KhachHangID,TongTien)"
                            + "values ('" + txt_mahd.Text + "',N'" + txt_manv.Text + "',N'" + txt_ngaylap.Text + "',N'" + txt_makh.Text + "',N'" + txt_tt.Text + "')";
            dgvhd.DataSource = provider.ExecuteNonQuery(query);
            loadNhanVien();
            txt_mahd.Clear();
            txt_manv.Clear();
            txt_ngaylap.Clear();
            txt_makh.Clear();
            txt_tongtien.Clear();
        }

        public void loadHoadon()
        {
            string query = "SELECT * FROM [QL_NhaHang].[dbo].[HoaDon]";
            dgvhd.DataSource = provider.ExecuteQuery(query);
            dgvhd.Columns[0].HeaderText = "Mã hóa đơn";
            dgvhd.Columns[1].HeaderText = "Mã nhân viên";
            dgvhd.Columns[2].HeaderText = "Ngày lập";
            dgvhd.Columns[3].HeaderText = "Mã khách hàng";
            dgvhd.Columns[4].HeaderText = "Tổng tiền";

        }
        private void hienthihoadon_Click(object sender, EventArgs e)
        {
            loadHoadon();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
