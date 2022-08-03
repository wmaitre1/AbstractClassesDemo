using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /* done 
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* done
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();
            

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var myCar = new Car();
            myCar.year = 2021;
            myCar.model = "Toyota";

            Console.WriteLine("-----------------------");

            myCar.Engine();
            myCar.Reverse();
            myCar.HasTrunk = true;

            var myTruck = new Car();
            myTruck.year = 2019;
            myTruck.model = "Tundra";

            Console.WriteLine("-----------------------");


            myTruck.Drive();
            myTruck.Reverse();
            myTruck.Engine();
            myTruck.HasTrunk = false;

            var myOffRoad = new Motorcycle();
            myOffRoad.make = "BMW";
            myOffRoad.model = "f850 Adventure";

            Console.WriteLine("-----------------------");


            myOffRoad.Drive();
            myOffRoad.Engine();

            Console.WriteLine("-----------------------");

            myOffRoad.HasSideCart = true;

            var myMotorcyle = new Motorcycle();
            myMotorcyle.year = 2022;
            myMotorcyle.model = "Ninja";
            myMotorcyle.make = "Kawasaki";

            Console.WriteLine("-----------------------");

            myMotorcyle.DriveVirtual();

            Console.WriteLine("-----------------------");

            myMotorcyle.Engine();
            myMotorcyle.Reverse();
            myMotorcyle.HasSideCart = true;


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(myOffRoad);
            vehicles.Add(myMotorcyle);
            vehicles.Add(myCar);
            vehicles.Add(myTruck);






            // Call each of the drive methods for one car and one motorcycle

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" Make {vehicle.make} Model {vehicle.model} Year {vehicle.year}");

                Console.WriteLine("------------------");

                vehicle.DriveAbstract();

                Console.WriteLine("------------------------------");

                vehicle.DriveVirtual();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
