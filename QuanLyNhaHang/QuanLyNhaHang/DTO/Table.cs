using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Table
    {
        private int banAnID;
        private String tenBan;
        private int soCho;
        private String trangThai;

        public Table(int banAnID, string tenBan, int soCho, string trangThai)
        {
            this.BanAnID = banAnID;
            this.TenBan = tenBan;
            this.SoCho = soCho;
            this.TrangThai = trangThai;
           
        }

        public Table( DataRow row)
        {
            this.BanAnID = (int)row["BanAnID"];
            this.TenBan = row["TenBan"].ToString();
            this.SoCho = (int)row["SoCho"];
            this.TrangThai = row["TrangThai"].ToString();
        }

        public int BanAnID 
        {
            get { return banAnID; }
            set { banAnID = value; }
        }

        public string TenBan 
        {
            get { return tenBan; }
            set { tenBan = value; }
        }

        public int SoCho 
        {
            get { return soCho; }
            set { soCho = value; }
        }

        public string TrangThai 
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

    }
}
