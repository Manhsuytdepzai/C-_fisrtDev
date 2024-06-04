using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ham_thamchieu
{
    internal class Program
    {
            static Boolean ktrangto(int a)
            {
                if (a < 0)
                    return false;
                else
                {
                    for (int i = 2; i < a; i++)
                    {
                        if (a % i == 0)
                            return false;    
                    }
                    return true;
                }
            }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int x;
            Console.WriteLine("nhap 1 so nguyentu ban phim : ");
            x =  Convert.ToInt16(Console.ReadLine());
            if (ktrangto(x) == true)
                Console.WriteLine("so vua nhap la so ngto");
            else
                Console.WriteLine("ko ngto");
            Console.ReadKey();

        }
    }
}
