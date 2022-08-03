using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Car is on the move!");
        }

        public override void Reverse()
        {
            Console.WriteLine($"Car is now reversing!");
        }
        public override void Engine()
        {
            Console.WriteLine($"Car does have a running engine!");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive. Vroom Vroom");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

        public bool HasTrunk { get; set; } = true;

    }




     
             //* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            // * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
           // * Provide the implementations for the abstract methods
           //  * Only in the Motorcycle class will you override the virtual drive method
}
