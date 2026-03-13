using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomClassLibrary
{
    public class Teglalap
    {
        public double OldalA { get; private set; }
        public double OldalB { get; private set; }
        public static List<Teglalap> TeglalapokListaja = new List<Teglalap>();
        public static double OsszesKerület { get; private set; }
        public static double OsszesTerület { get; private set; }

        public Teglalap(double a, double b)
        {
            this.OldalA = a;
            this.OldalB = b;
            OsszesKerület += this.TeglalapKerulet();
            OsszesTerület += this.TeglalapTerulet();
            TeglalapokListaja.Add(this);
        }

        public double TeglalapKerulet()
        {
            return 2 * (this.OldalA + OldalB);
        }
        public double TeglalapTerulet()
        {
            return this.OldalA * this.OldalB;
        }
    }
}

