using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomClassLibrary
{
    public class Kor
    {
        public double Sugar { get; private set; }
        public static List<Kor> KorokListaja=new List<Kor>();
        public static double OsszesKerület { get; private set; } = 0;       
        public static double OsszesTerület { get; private set; } = 0;


        public Kor(double sugar)
        {
        this.Sugar = sugar;
            OsszesKerület += this.KorKerulet();
            OsszesTerület += this.KorTerulet();
            KorokListaja.Add(this);
        }
        public double KorKerulet()
        {
            return Math.Round(this.Sugar * 2*Math.PI, 2);
        }
        public double KorTerulet()
        {
            return Math.Round(Math.Pow(this.Sugar,2) * Math.PI, 2);
        }
    }
}
