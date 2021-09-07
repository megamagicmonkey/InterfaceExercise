using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany
    {
        public int bedSize;
        public bool hasWinch;

        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int GearSpeeds { get; set; }
        public bool IsElectric { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }

        public void PrintStats(Truck car)
        {
            Console.WriteLine($"This vehicle brought to you by {car.Name}");
            Console.WriteLine($"{car.Name} - {car.Slogan}");
            Console.WriteLine("Stats:");
            Console.WriteLine($"Doors - {car.Doors}");
            Console.WriteLine($"Wheels - {car.Wheels}");
            Console.WriteLine($"Gear Speeds - {car.GearSpeeds}");
            Console.WriteLine($"Trunk Size - {car.bedSize} cubic inches.");
            if (car.IsElectric)
            {
                Console.WriteLine("Electric - Yes");
            }
            else
            {
                Console.WriteLine("Electric - No");
            }
            if (car.hasWinch)
            {
                Console.WriteLine("Winch Equipped - Yes");
            }
            else
            {
                Console.WriteLine("Winch Equipped - No");
            }
        }
    }
}
