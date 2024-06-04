using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhtron1
{
    internal class hinhtron
    {
        class Hinh
        {
            protected string mau_sac;
            public Hinh(string mau_sac = "den")
            {
                this.mau_sac = mau_sac;
            }

            public virtual void nhap()
            {
                Console.WriteLine("nhap  mau sac : ");
                this.mau_sac = Console.ReadLine();
            }

            public virtual void intt()
            {
                Console.WriteLine($"mau sac: {mau_sac}");

            }
        };

        class Hinhtron : Hinh
        {
            private double r;
            public Hinhtron(string mau_sac = "", double r = 0) : base(mau_sac)
            {
                this.r = r;
            }
            public override void nhap()
            {
                base.nhap();
                Console.WriteLine("nhap ban kinh hinh tron: ");
                this.r = Convert.ToDouble(Console.ReadLine());
            }

            public double chuvi()
            {
                return (2 * 3.14 * r);
            }
            public double dientich()
            {
                return (3.14 * r * r);
            }
            public override void intt()
            {
                base.intt();
                Console.WriteLine("ban kinh hinh tron la : " + r);
                Console.WriteLine("chu vi hinh tron la: " + chuvi());
                Console.WriteLine("dien tich hinh tron la: " + dientich());
            }
        };


        class HinhCN : Hinh
        {
            private double dai;
            private double rong;

            public HinhCN(string mau_sac = "", double dai = 0, double rong = 0) : base(mau_sac)
            {
                this.dai = dai;
                this.rong = rong;
            }

            public override void nhap()
            {
                base.nhap();
                Console.WriteLine("nhap chieu daichinh CN: ");
                dai = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("nhap chieu rong hinh chu nhat: ");
                rong = Convert.ToDouble(Console.ReadLine());
            }

            public double chuvi()
            {
                return 2 * (dai + rong);

            }

            public double dientich()
            {
                return dai * rong;
            }

            public override void intt()
            {
                base.intt();
                Console.WriteLine("chieu dai HCN : " + dai);
                Console.WriteLine("chieu rong HCN : " + rong);
                Console.WriteLine("chu vi HCN: " + chuvi());
                Console.WriteLine("dien tich HCN: " + dientich());
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Hinh h1;
            h1 = new Hinhtron();
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("nhap thong tin cho hinhh tron : ");
            h1.nhap();

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("in thong tin cho hinh tron : ");
            h1.intt();

            //-------------------------------------------------
            //HCN

            h1 =  new HinhCN();
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("nhap thong tin cho hinhh CN : ");
            h1.nhap();

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("in thong tin cho hinh CN : ");
            h1.intt();

            Console.ReadKey();
        }
    }
}
