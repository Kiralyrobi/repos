using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KönyvekClassLibrary;

namespace KönyCon
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Kérem adja meg a könyv címét: ");
                string KonyvCim = Console.ReadLine();
                if (KonyvCim == "stop") { break; }
                Console.Write("Kérem adja meg a szerző nevét: ");
                string KonyvSzerzo = Console.ReadLine();
                Console.Write("Kérem adja meg a könyv oldalszámát: ");
                int KonyvOldal = int.Parse(Console.ReadLine());
                Console.WriteLine();
                try
                {
                    var newObj = new Könyv(KonyvCim, KonyvSzerzo, KonyvOldal);
                    Könyv.Konyvlista.Add(newObj);
                }

                catch (Exception e)
                {
                    Console.WriteLine("Hiba");
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Könyvek listája:");
            foreach (var konyv in Könyv.Konyvlista)
            {
                Console.WriteLine($"A könyv címe: {konyv.Cim}, A könyv szerzője: {konyv.Szerzo}, A könyv oldalSzáma: {konyv.Oldalszam}");
                Console.Write($"Olvasás ideje {konyv.OlvasasIdeje()}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}