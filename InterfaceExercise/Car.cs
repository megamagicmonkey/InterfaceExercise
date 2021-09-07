using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int GearSpeeds { get; set; }
        public bool IsElectric { get; set; }

        public int trunkSize;
        public bool hasSportMode;




        public void PrintStats(Car car)
        {
            Console.WriteLine($"This vehicle brought to you by {car.Name}");
            Console.WriteLine($"{car.Name} - {car.Slogan}");
            Console.WriteLine("Stats:");
            Console.WriteLine($"Doors - {car.Doors}");
            Console.WriteLine($"Wheels - {car.Wheels}");
            Console.WriteLine($"Gear Speeds - {car.GearSpeeds}");
            Console.WriteLine($"Trunk Size - {car.trunkSize} cubic inches.");
            if (car.IsElectric)
            {
                Console.WriteLine("Electric - Yes");
            }
            else
            {
                Console.WriteLine("Electric - No");
            }
            if (car.hasSportMode)
            {
                Console.WriteLine("Sport Mode - Yes");
            }
            else
            {
                Console.WriteLine("Sport Mode - No");
            }
        }
    }
}
