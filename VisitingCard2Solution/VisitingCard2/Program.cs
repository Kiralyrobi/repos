using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1Visiting;

namespace VisitingCard2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Gotham's Best Visiting Card Maker*****");

            Console.Write("Your Name: ");
            string name = Console.ReadLine();

            Console.Write("DOB(dd-MM-yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.Write("Street Address: ");
            string street = Console.ReadLine();

            Console.Write("PostCode: ");
            string postcode = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Your speciality: ");
            string designation = Console.ReadLine();

            VisitingCardCreator card = new VisitingCardCreator();
            card.PrintVisitingCard(name, dob, street, postcode, city, designation);

            Console.ReadKey();
        }
    }
}