using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokClassLibrary
{
    public class osztaly
    {
        public string Nev { get; private set; }
        public int Pontszam { get; private set; }
        public static int MaxPontszam { get; private set; }

        public osztaly(string nev, int pont)
        {
            Nev = nev;
            Pontszam = pont;
        }

        // Maximális pontszám beállítása
        public static void BeallitMaxPont(int maxPont)
        {
            MaxPontszam = maxPont;
        }

        // Százalék számítása
        public double Szazalek()
        {
            return (double)Pontszam / MaxPontszam * 100;
        }

        // Jegy meghatározása
        public int Jegy()
        {
            double sz = Szazalek();

            if (sz >= 90) return 5;
            if (sz >= 75) return 4;
            if (sz >= 60) return 3;
            if (sz >= 40) return 2;
            return 1;
        }
    }
}