using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKektura
{
    public class Kektura
    {
        public string KiinduloPont {  get; private set; }
        public string VegPont { get; private set; }
        public double SzakaszHosszKm { get; private set; }
        public int Emelkedes {  get; private set; }
        public int Lejtes { get; private set; }
        public bool Pecsetelohely {  get; private set; }
        public static int Kezdomagassag {  get; private set; }

        public static List<Kektura> KekturaLista = new List<Kektura>();


        //Konstruktor
        public Kektura(string sor)
        {
            string[] db=sor.Split(';');
            this.KiinduloPont = db[0];
            this.VegPont = db[1];
            this.SzakaszHosszKm= double.Parse(db[2]);
            this.Emelkedes=int.Parse(db[3]);
            this.Lejtes=int.Parse(db[4]);
            if (db[5] == "i")
            {
                this.Pecsetelohely = true;
            }
            else
            {
                this.Pecsetelohely = false;
            }
        }


        public static List<Kektura> FileBeolvasas(string filenev)
        {
            try
            {
                StreamReader sr = new StreamReader(filenev);
                Kezdomagassag = int.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    var obj = new Kektura(sr.ReadLine());
                    KekturaLista.Add(obj);
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Hiba a file megnyitása során");
            }
            return KekturaLista;
        }

    }
}
