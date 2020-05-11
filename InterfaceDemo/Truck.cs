using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Truck:Automobile
    {
        
        //Adding method that is not in the interface

        public void Rollover()
        {
            Console.WriteLine("Truck is rolling over");

        }

        public override void Wash()
        {
            Console.WriteLine("Truck is washed");
        }
    }
}
