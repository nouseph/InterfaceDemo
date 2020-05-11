using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Car : Automobile
    {
        
        //Adding method that is not in the interface

        public void Fly()
        {
            Console.WriteLine("Car is flying.");

        }

        public override void Wash()
        {
            Console.WriteLine("Car is washed");
        }
    }
}
