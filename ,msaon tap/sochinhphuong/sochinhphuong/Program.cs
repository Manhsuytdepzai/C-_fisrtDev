using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sochinhphuong
{
    internal class Program
    {

        static Boolean ktrachinhphuong(int a)
        {
            for (int i = (-a + 1); i < a; i++)
            {
                if (Math.Pow(i, 2) == a)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int x;
            Console.WriteLine("nhap 1 so nguyen tu ban phim : ");
            x = Convert.ToInt16(Console.ReadLine());
            if (ktrachinhphuong(x) == true)
                Console.WriteLine("so vua nhap la so chinh phuong");
            else
                Console.WriteLine("ko chinh phuong");
            Console.ReadKey();
        }
    }
}
