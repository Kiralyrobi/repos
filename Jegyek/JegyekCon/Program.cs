using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanulokClassLibrary;

namespace JegyekCon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add meg a dolgozat maximális pontot:");
            int maxPont = int.Parse(Console.ReadLine());

            osztaly.BeallitMaxPont(maxPont);

            List<osztaly> tanulok = new List<osztaly>();

            while (true)
            {
                Console.WriteLine("Add meg a tanuló nevét (vége = kilépés):");
                string nev = Console.ReadLine();

                if (nev.ToLower() == "vége") break;

                Console.WriteLine("Add meg az elért pontszámát:");
                int pont = int.Parse(Console.ReadLine());

                tanulok.Add(new osztaly(nev, pont));
            }

            Console.WriteLine("\n--- Tanulók eredményei ---");

            foreach (var t in tanulok)
            {
                Console.WriteLine($"{t.Nev} – {t.Pontszam} pont / {osztaly.MaxPontszam}, " +
                                  $"Százalék: {t.Szazalek():0.00}%, Jegy: {t.Jegy()}");
            }

            Console.WriteLine($"\nDolgozat maximális pontszáma: {osztaly.MaxPontszam}");
        }
    }
}

