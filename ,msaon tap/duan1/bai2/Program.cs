
using System;
using System.Text;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            Console.WriteLine("nhập vào số nguyên n");
            n = Convert.ToInt16(Console.ReadLine());
            /*float s=0;
            /*for (int i = 0; i < n; i++)
            {
                s += i;
                Console.WriteLine(i);
            }
            int i = 0;
            while( i < n) {
                s += i;
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("tong : " + s);*/
            int[] mang1 = new int[n];
            Console.WriteLine("cac so trong mang la : ");
            /*foreach (int i in mang1)
            {
                Console.WriteLine(i);
            }*/
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("so thu "+(i+1));
                mang1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
