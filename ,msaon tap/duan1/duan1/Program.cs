using System.Text;

namespace duan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Hello, World!");
            int a;
            a = 6;
            Console.WriteLine(a);
            string s1 = "Manhsuytdepzai";
            Console.WriteLine("MAy noi la "+s1);
            string s2 = "thang an cut";
            string s3 = "vu dang";
            Console.WriteLine("chuoi plus {0} {1} {2}",s1,s2, s3);
            string s4;
            Console.WriteLine("nnhap chuoi vao tu ban phim : ");
            s4 = Console.ReadLine();
            Console.WriteLine("///--------------------------------------///");
            Console.Write("chuoi vua nhap la : " + s4);
            Console.ReadKey();
        }
    }
}
