using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlygai.ketnoi
{
    internal class Dataprovider
    {
        private string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mmmma\\Documents\\Documents\\c#\\Quanlygai\\Quanlygai\\bin\\Debug\\Qly_nhanvien.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listpara)
                    {
                        if(para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, i);
                            i++;
                        }    
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listpara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, i);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
                con.Close();
            }
            return dt;
        }

    }
}
