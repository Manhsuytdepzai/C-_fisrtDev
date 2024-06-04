using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sang1chieu
{
    internal class Program
    {
            static void doiChoHaiSoNguyen(int a, int b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Giá trị của x trong khi gọi hàm = {a}");
                Console.WriteLine($"Giá trị của y trong khi gọi hàm = {b}");
            }

            static void Main(string[] args)
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int x, y;
                Console.Write("Nhập số nguyên thứ nhất x = ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nhập số nguyên thứ hai y = ");
                y = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Giá trị của x trước khi gọi hàm = {x}");
                Console.WriteLine($"Giá trị của y trước khi gọi hàm = {y}");

                doiChoHaiSoNguyen(x, y);

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Giá trị của x sau khi gọi hàm = {x}");
                Console.WriteLine($"Giá trị của y sau khi gọi hàm = {y}");

                Console.ReadKey();
            }

        }
    
}
