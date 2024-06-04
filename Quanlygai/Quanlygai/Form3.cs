using Quanlygai.ketnoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlygai
{
    public partial class Form3 : Form
    {
        Dataprovider provider = new Dataprovider();
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadtt();
        }

        void loadtt()
        {
            string query = "select * from hang";
            dtg_tt.DataSource = provider.ExecuteQuery(query);
            dtg_tt.Columns[0].HeaderText = "Mã hàng";
            dtg_tt.Columns[1].HeaderText = "Tên hàng";
            dtg_tt.Columns[2].HeaderText = "Đơn giá";
            dtg_tt.Columns[3].HeaderText = "Đơn vị";
            dtg_tt.Columns[4].HeaderText = "Số lượng";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string ma= txt_ma.Text;
            string ten = txt_ten.Text;
            string dg = txt_dg.Text;
            string dv  = txt_dv.Text;
            string sl = txt_sl.Text;
            string query = $"insert into hang(mahang,ten,dg,dv,sl) values (N'"+ma+ "',N'"+ten+"',N'"+dg+"',N'"+dv+"',N'"+sl+"')";
            dtg_tt.DataSource=provider.ExecuteNonQuery(query);
            loadtt();
            txt_ma.Clear();
            txt_ten.Clear();
            txt_dg.Clear();
            txt_dv.Clear();
            txt_sl.Clear();
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string ma = txt_ma.Text;
            string ten = txt_ten.Text;
            string dg = txt_dg.Text;
            string dv = txt_dv.Text;
            string sl = txt_sl.Text;  
            string query = "update hang set ";
            query += "ten = '"+ ten + "',";
            query += "dg = '" + dg + "',";
            query += "dv = '" + dv + "',";
            query += "sl = '" + sl + "'";
            query += "where mahang = '" + ma + "'";
            dtg_tt.DataSource = provider.ExecuteNonQuery(query);
            loadtt();
        }

        private void dtg_tt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dtg_tt[0, e.RowIndex].Value.ToString();
            txt_ten.Text = dtg_tt[1, e.RowIndex].Value.ToString();
            txt_dg.Text = dtg_tt[2,e.RowIndex].Value.ToString();
            txt_dv.Text = dtg_tt[3,e.RowIndex].Value.ToString();
            txt_sl.Text = dtg_tt[4,e.RowIndex].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string macx = txt_ma.Text;
            string query = "delete from hang where mahang = '" + macx + "'";
            dtg_tt.DataSource = provider.ExecuteNonQuery(query);
            loadtt();
            txt_ma.Clear();
            txt_ten.Clear();
            txt_dg.Clear();
            txt_dv.Clear();
            txt_sl.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
