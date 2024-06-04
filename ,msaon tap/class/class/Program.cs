using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    public class CongDan_1
    {
        private int so_cccd;
        private string ho_ten;
        private int tuoi;

        public void inThongTin()
        {
            Console.WriteLine($"Số căn cước công dân là: {so_cccd}");
            Console.WriteLine($"Họ tên công dân là: {ho_ten}");
            Console.WriteLine($"Tuổi công dân là: {tuoi}");
        }

        public int TuoiCongDan
        {
            get { return tuoi= Convert.ToInt16(Console.ReadLine()); ; }
            set { this.tuoi = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CongDan_1 cd1 = new CongDan_1();
            Console.WriteLine("THÔNG TIN VỀ CÔNG DÂN 1: ");
            cd1.inThongTin();

            CongDan_1 cd2 = new CongDan_1();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("THÔNG TIN VỀ CÔNG DÂN 2: "+cd2.TuoiCongDan);
            
            cd2.inThongTin();


            CongDan_1 cd3 = new CongDan_1();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            cd3.TuoiCongDan = Convert.ToInt16(Console.ReadLine());

            int tuoi3 = cd3.TuoiCongDan;
            Console.Write($"Tuổi của công dân thứ 3 là: {tuoi3} \n");


            Console.ReadKey();
        }
    }

}
