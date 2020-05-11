using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IAutomobile
    {
        //Only the definition of properties and methods and not the implementation


        public string Make { get; set; }
        public string Model { get; set; }
        public int VIN { get; set; }

        public void Start(int speed);
        public void Stop();
    }
}
