using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KönyvekClassLibrary
{
    public class Könyv
    {
        public string Cim { get; private set; }
        public string Szerzo { get; private set; }
        public int Oldalszam { get; private set; }
        int OlvasasIdo = 2;

        public static List<Könyv> Konyvlista = new List<Könyv>();
        public Könyv(string cim, string szerzo, int oldalszam)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
        }
        public int OlvasasIdeje()
        {
            return (Oldalszam * OlvasasIdo);
        }
    }
}
