using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manh
{
    class dathucbac3
    {
        private int he_so3;
        private int he_so2;
        private int he_so1;
        private int he_so0;

        public dathucbac3(int he_so3, int he_so2, int he_so1, int he_so0)
        {
            this.he_so3 = he_so3;
            this.he_so2 = he_so2;
            this.he_so1 = he_so1;
            this.he_so0 = he_so0;
        }
        public void indathuc()
        {
            Console.WriteLine($"\t{he_so3}*x^3 + {he_so2}*x^2 + {he_so1}*x + {he_so0}");
        }
        public dathucbac3 tinhTong(dathucbac3 dt)   // Hàm có 1 tham số
        {
            dathucbac3 tong = new dathucbac3();
            tong.he_so3 = this.he_so3 + dt.he_so3;
            tong.he_so2 = this.he_so2 + dt.he_so2;
            tong.he_so1 = this.he_so1 + dt.he_so1;
            tong.he_so0 = this.he_so0 + dt.he_so0;
            return tong;
        }
    }
     class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            dathucbac3 dt1, dt2, dt3;

            dt1 = new dathucbac3);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("IN THÔNG TIN ĐA THỨC THỨ NHẤT: ");
            dt1.indathuc();


            dt2 = new dathucbac3(3, 10, 12, 8);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("IN THÔNG TIN ĐA THỨC THỨ HAI: ");
            dt2.indathuc();

            dathucbac3 tong;
            tong = new dathucbac3();
            tong = dt1.tinhTong(dt2);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("TỔNG 2 ĐA THỨC LÀ: ");
            tong.indathuc();


            Console.ReadKey();
        }
    }
