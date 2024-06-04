using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int x;
            int m,n;
            Console.Write("nhap so phan tu m cua mang : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so phan tu n cua mang : ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write("a[" + i + "] [" + j + "]= ");
                    x = Convert.ToInt16(Console.ReadLine());
                    a.SetValue(x, i, j);
                }
            }
            Console.WriteLine("mang da nhap la :  ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "] [" + j + "]= ");
                    Console.Write("{0} \t",a[i,j]);
                    Console.Write("\n");
                }
            }
        }
    }
}
