using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    abstract class Automobile : IAutomobile
    {
        public string Make { get ; set; }
        public string Model { get; set; }
        public int VIN { get; set; }

        public void Start(int speed)
        {
            Console.WriteLine($"Automobile is running at {speed} mph.");
        }

        public void Stop()
        {
            Console.WriteLine("Automobile has stopped");   
        }
        //Abstract method
        public abstract void Wash();

    }
}
