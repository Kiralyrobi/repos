using ClassLibraryFürjes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryFürjes
{
    public class ClassFurj
    {
        public int Sorszam { get; private set; }
        public string Fajta { get; private set; }
        public int TojikE { get; private set; }
        public int Eletkor { get; private set; }
        public static List<ClassFurj> FürjekLista = new List<ClassFurj>();
        public ClassFurj(string sor)
        {
            string[] db = sor.Split(',');

            this.Sorszam = int.Parse(db[0]);
            this.Fajta = db[1];
            this.TojikE = db[2].ToLower()=="igen"? 1:0;
            this.Eletkor = int.Parse(db[3]);

            FürjekLista.Add(this);

        }
        public override string ToString()
        {
            return Sorszam + " - " + Fajta + " - Tojik: " + TojikE + " - Életkor: " + Eletkor;
        }

        public static List<ClassFurj> FileBeolvasas(string filename)
        {
            try
            {
                StreamReader sr=new StreamReader(filename);
                while(!sr.EndOfStream)
                {
                    new ClassFurj(sr.ReadLine());
                }
                sr.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return FürjekLista;
        }

    }
}