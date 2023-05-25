using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "Generic Value";
        public string Make { get; set; } = "Generic Value";
        public string Model { get; set; } = "Generic Value";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Default Virtual Drive Method");
        }


    }
}
