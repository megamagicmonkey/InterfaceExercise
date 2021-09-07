using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructions
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            #endregion

            Car LowRider = new Car() { Doors = 2, GearSpeeds = 9, IsElectric = false, Wheels = 4, hasSportMode = true, trunkSize = 816, Name = "Aquata", Slogan = "Fluid motion." };
            SUV SoccaMomma = new SUV() { Doors = 6, GearSpeeds = 5, IsElectric = true, Wheels = 4, cargoHoldSize = 9001, hasTV = true, Name = "Vapor", Slogan = "Feel the air." };
            Truck HoldMaBeer = new Truck() { Doors = 2, GearSpeeds = 6, IsElectric = false, Wheels = 6, bedSize = 404, hasWinch = true, Name = "Metallia", Slogan = "Superior materials. Superior minds. Superior creations." };

            LowRider.PrintStats(LowRider);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            SoccaMomma.PrintStats(SoccaMomma);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            HoldMaBeer.PrintStats(HoldMaBeer);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        }

    }
}
