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

namespace testfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con1;
        SqlCommand cmd1;
        SqlDataReader reader;

        void ketnoi()
        {
            String str_con = @"Data Source=DESKTOP-09OL4KM\SQLEXPRESS;Initial Catalog=testfile;Integrated Security=True";
            con1 = new SqlConnection(str_con);

            con1.Open();
        }

        void taidulieu()
        {
            ketnoi();
            String str_tai = "Select * From manh";

            //tạo đói tượng thực thi
            cmd1 = new SqlCommand();
            cmd1.Connection = con1;
            cmd1.CommandText = str_tai;
            //đọc dữ liệu
            reader = cmd1.ExecuteReader();

            // đọc dữ liệu đưa lên listview
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader[0].ToString();
                item.SubItems.Add(reader[1].ToString());
               // item.SubItems.Add(reader[2].ToString());
                testtable.Items.Add(item);
            }
            con1.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //testtable.Items.Clear();
            taidulieu();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
