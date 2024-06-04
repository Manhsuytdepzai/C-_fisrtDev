using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang1chieu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            a = new int[50,60];
            int x;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    x = Convert.ToInt16(Console.ReadLine());
                    //Console.Write("a[" + i + "] [" + j + "]" = );
                    a.SetValue(x, i, j);
                }
            }
        }
    }
}
