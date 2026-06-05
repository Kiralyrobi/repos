using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySzoba;

namespace ConsoleSzoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a Konzolos applikáció egy szoba alapadataiból számítja ki amit csak lehet...\n");
            Console.Write("Hosszúság: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Szélesség: ");
            double sz = double.Parse(Console.ReadLine());
            Console.Write("Magasság: ");
            double m = double.Parse(Console.ReadLine());

            Szoba obj=new Szoba(h, sz, m);

            Console.WriteLine($"\nA szoba\n" +
                $"\tAlapterülete: {obj.Alapterulet()} nm\n" +
                $"\tTérfogata: {obj.Terfogat()} légköbméter\n" +
                $"\tFalak felülete: {obj.FalFelulet()} nm\n");

            Console.ReadKey();

        }
    }
}
