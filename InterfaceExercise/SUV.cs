using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany
    {
        public int cargoHoldSize;
        public bool hasTV;

        public int Wheels { get ; set ; }
        public int Doors { get ; set ; }
        public int GearSpeeds { get ; set ; }
        public bool IsElectric { get ; set ; }
        public string Name { get ; set ; }
        public string Slogan { get ; set ; }

        public void PrintStats(SUV car)
        {
            Console.WriteLine($"This vehicle brought to you by {car.Name}");
            Console.WriteLine($"{car.Name} - {car.Slogan}");
            Console.WriteLine("Stats:");
            Console.WriteLine($"Doors - {car.Doors}");
            Console.WriteLine($"Wheels - {car.Wheels}");
            Console.WriteLine($"Gear Speeds - {car.GearSpeeds}");
            Console.WriteLine($"Trunk Size - {car.cargoHoldSize} cubic inches.");
            if (car.IsElectric)
            {
                Console.WriteLine("Electric - Yes");
            }
            else
            {
                Console.WriteLine("Electric - No");
            }
            if (car.hasTV)
            {
                Console.WriteLine("TV Equipped - Yes");
            }
            else
            {
                Console.WriteLine("TV Equipped - No");
            }
        }
    }
}
