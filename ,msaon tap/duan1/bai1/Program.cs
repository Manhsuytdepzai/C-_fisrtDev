using System;
using System.Text;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b;
            Console.WriteLine("nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("nhap b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\ntong a + b = " + (a + b));
            Console.ReadKey();
        }
    }
}
