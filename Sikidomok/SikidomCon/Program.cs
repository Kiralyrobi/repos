using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikidomClassLibrary;

namespace SikidomCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-rész: Kör adatainak gyűjtése\n"+
                "\tAdd meg a kör sugarát (üres ENTER=vége\n");
            while (true)
            {
                Console.Write("--> ");
                string input = Console.ReadLine();
                if (input == "") { break; }
                try
                {
                    double sugar = double.Parse(input);
                    if (sugar > 0)
                    {
                        //példányosítás
                        var ujObj = new Kor(sugar);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Helyes adatot kérek.");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Helyes adatot kérek.");
                    Console.WriteLine(e.Message);
                }
            }

                Console.WriteLine("\nKörök adatait listázzuk\n");
                foreach(var kor in Kor.KorokListaja)
                {
                    Console.WriteLine($"A(z) {kor.Sugar} sugarú kör kerülete:{kor.KorKerulet()} Területe{kor.KorTerulet()}");
                }
                Console.WriteLine($"\nÖsszes Kerület: {Kor.OsszesKerület}\n"+
                    $"Összes Terület{Kor.OsszesTerület}");





            Console.WriteLine("2-rész: Téglalap adatainak gyűjtése\n" +
               "\tAdd meg a Téglalap egyik oldalát (üres ENTER=vége\n");
            Console.WriteLine("Add meg a téglalap másik oldalát ");
            while (true)
            {
                Console.WriteLine("a oldal");
                Console.Write("--> ");
                string a = Console.ReadLine();



                Console.WriteLine("b oldal");
                Console.Write("-->");
                string b = Console.ReadLine();
                if (a == "" || b=="") { break; }
   
                try
                {
                    double oldala = double.Parse(a);
                    double oldalb=double.Parse(b);
                    if (oldala > 0 && oldalb>0)
                    {
                        //példányosítás
                        var ujObj = new Teglalap(oldala, oldalb);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Helyes adatot kérek.");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Helyes adatot kérek.");
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nTéglalap adatait listázzuk\n");
            foreach (var teglalap in Teglalap.TeglalapokListaja)
            {
                Console.WriteLine($"A(z) Téglalap Kerülete {teglalap.TeglalapKerulet()} Területe{teglalap.TeglalapTerulet()}");
            }
            Console.WriteLine($"\nÖsszes Kerület: {Teglalap.OsszesKerület}\n" +
                $"Összes Terület: {Teglalap.OsszesTerület}");

            
            Console.ReadKey();
            
        }
    }
}
