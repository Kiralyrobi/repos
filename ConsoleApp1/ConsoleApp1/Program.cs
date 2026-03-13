using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallascon
{
    internal class Program
    {
        public struct Hotel
        {
            public string Name;
            public string Address;
            public int NumberOfRoom;
            public int NumberOfBed;
            public string OperatorName;
            public string OperatorAddress;
            public string OperatorPhone;
            public string Status;
            public string Type;
        }

        static void Main(string[] args)
        {
            List<Hotel> hotel = GetHotelList("szallas2022.csv");
            Console.WriteLine($"Az összes szálláshelyek száma: {GetHotelCount(hotel)}");
            Console.WriteLine($"Átlagos ágyszám az aktív szálláshelyeken: {GetNumberOfActiveBed(hotel):F2}");
            PrintActiveHotelsByTown(hotel);
        }

        public static List<Hotel> GetHotelList(string filename)
        {
            List<Hotel> rooms = new List<Hotel>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                sr.ReadLine();
                string Rooms;
                while(!sr.EndOfStream) 
                    //((Rooms = sr.ReadLine()) != null)
                {
                    Rooms = sr.ReadLine();
                    Hotel room;

                    string[] roomData = Rooms.Split(';');
                    room.Name = roomData[0];
                    room.Address = roomData[1];
                    room.NumberOfRoom = int.Parse(roomData[2]);
                    room.NumberOfBed = int.Parse(roomData[3]);
                    room.OperatorName = roomData[4];
                    room.OperatorAddress = roomData[5];
                    room.OperatorPhone = roomData[6];
                    room.Status = roomData[7];
                    room.Type = roomData[8];

                    rooms.Add(room);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a file olvasása során! " + e.Message);
            }
            return rooms;
        }
        public static int GetHotelCount(List<Hotel> hotel)
        {
            int count = 0;
            foreach(var t in hotel)
            {
                count++;
            }
            return count;
        }
        public static double GetNumberOfActiveBed(List<Hotel> hotel)
        {
            double number = 0;
            int count = 0;
            foreach (var bed in hotel)
            {
                if (bed.Status == "Aktív")
                {
                    number += bed.NumberOfBed;
                    count++;
                }
            }
            double atlag = number / count;
            return Math.Round(atlag, 2);
        }
        public static void PrintActiveHotelsByTown(List<Hotel> hotel)
        {
            Dictionary<string, int> towns = new Dictionary<string, int>();

            foreach (var h in hotel)
            {
                if (h.Status == "Aktív")
                {
                    string town = GetTownFromAddress(h.Address);
                    if (towns.ContainsKey(town))
                    {
                        towns[town]++;
                    }
                    else
                    {
                        towns[town] = 1;
                        //towns.Add(town, 1);
                    }
                }
            }
            Console.WriteLine("Szeghalom környéki aktív szállások:");
            foreach (var t in towns)
            {
                Console.WriteLine($"\t\t{t.Key}: {t.Value} db");
            }
        }
        public static string GetTownFromAddress(string address)
        {
            var parts = address.Split(' ');
            return parts.Length > 1 ? parts[1] : address;
        }
    }
}