using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1Visiting
{
    public class VisitingCardCreator
    {
        public void PrintVisitingCard(string name, DateTime dob, string street, string postcode, string city, string designation)
        {
            TimeSpan timeSpan = DateTime.Now - dob;
            int totalDays = (int)timeSpan.TotalDays;

            string lastName = name.Split(' ')[name.Split(' ').Length - 1];

            Console.WriteLine();
            Console.WriteLine("******** Output ********");
            Console.WriteLine();
            Console.WriteLine($"Hello {lastName} Here is your visiting card");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(designation);
            Console.WriteLine(street);
            Console.WriteLine($"{postcode} {city}");
            Console.WriteLine($"Born: {totalDays} Days ago");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}