using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Motorcycle is on the move!");
        }

        public override void Reverse()
        {
            Console.WriteLine($"Motorcycle is now reversing!");
        }
        public override void Engine()
        {
            Console.WriteLine($"Motorcycle does have a running engine!");
        }

        public override void DriveAbstract()
        {
            
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} will never slow down.  It is on the open road");
        }

        public bool HasSideCart { get; set; }


    }
}
