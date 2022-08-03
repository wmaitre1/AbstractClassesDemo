using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int year { get; set; } = 1;
        public string make { get; set; } = "Default Make";
        public string model { get; set; } = "Default Model";
        public abstract void DriveAbstract();

        public abstract void Drive();
        public abstract void Reverse();

        public abstract void Engine();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType() .Name} is virtually in drive");
        }

      

       
    }




    
            // * Create an abstract class called Vehicle
            //* The vehicle class shall have three string properties Year, Make, and Model
            // * Set the defaults to something generic in the Vehicle class
            // * Vehicle shall have an abstract method called DriveAbstract with no implementation
           //  * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
            // * 
}
