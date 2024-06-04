using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dathucbac3_1
{
    class DaThucBac3
    {
        private int he_so_3;
        private int he_so_2;
        private int he_so_1;
        private int he_so_0;

        public DaThucBac3(int hs3 = 1, int hs2 = 2, int hs1 = 3, int hs0 = 4)
        {
            this.he_so_3 = hs3;
            this.he_so_2 = hs2;
            this.he_so_1 = hs1;
            this.he_so_0 = hs0;
        }

        public void inDaThucBac3()
        {
            Console.WriteLine($"\t{he_so_3}*x^3 + {he_so_2}*x^2 + {he_so_1}*x + {he_so_0}");
        }

        public DaThucBac3 tinhTong(DaThucBac3 dt)   // Hàm có 1 tham số
        {
            DaThucBac3 tong = new DaThucBac3();
            tong.he_so_3 = this.he_so_3 + dt.he_so_3;
            tong.he_so_2 = this.he_so_2 + dt.he_so_2;
            tong.he_so_1 = this.he_so_1 + dt.he_so_1;
            tong.he_so_0 = this.he_so_0 + dt.he_so_0;
            return tong;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            DaThucBac3 dt1, dt2, dt3;

            dt1 = new DaThucBac3();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("IN THÔNG TIN ĐA THỨC THỨ NHẤT: ");
            dt1.inDaThucBac3();


            dt2 = new DaThucBac3(3, 10, 12, 8);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("IN THÔNG TIN ĐA THỨC THỨ HAI: ");
            dt2.inDaThucBac3();

            //DaThucBac3 tong;
            //tong = new DaThucBac3();
            //tong = dt1.tinhTong(dt2);
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("TỔNG 2 ĐA THỨC LÀ: ");
            //tong.inDaThucBac3();

            dt3 = new DaThucBac3(2, -4, 6, -10);
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("IN THÔNG TIN ĐA THỨC THỨ BA: ");
            dt3.inDaThucBac3();

            DaThucBac3 tong3 = new DaThucBac3();
            tong3 = (dt1.tinhTong(dt2)).tinhTong(dt3);  // chạy đúng, nhưng không tiện
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("TỔNG 3 ĐA THỨC LÀ: ");
            tong3.inDaThucBac3();


            Console.ReadKey();
        }
    }
}
