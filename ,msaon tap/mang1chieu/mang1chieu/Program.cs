namespace mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            a= new int[10];
            a.SetValue(12, 3);
            int x;
            x= Convert.ToInt16(a.GetValue(3));
            Console.WriteLine(x);
        }
    }
}
