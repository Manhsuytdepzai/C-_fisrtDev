using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[50];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            //sap xep
            int x;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (a[i] < a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            //tim kiem
            int tk;
            Console.Write("nhap vi tri muon tim trong mamng : ");
            tk = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (a[i] == a[tk])
                {
                    Console.Write("phan tu can tim la : " + a[i]);
                    Console.Write("\n");
                }
            }
            //xoa phan tu
            int k ,u;
            Console.Write("nhap vi tri muon xoa : ");
            k = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] == a[k])
                    {
                        a[i] = a[j];
                    }
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
