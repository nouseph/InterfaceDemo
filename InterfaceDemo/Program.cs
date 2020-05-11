using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //You cannot instantiate interface

            var car = new Car();
            car.Fly();
            car.Start(35);
            car.Stop();
            car.Wash();



            //Typecast instance of the car into iAutomobile
            var a = (IAutomobile)car;
            a.Start(45);
            a.Stop();
            

            var truck = new Truck();

            //Typecast instance of the truck into iAutomobile
            var t = (IAutomobile)truck;
            truck.Wash();

            //You cannot create instance of abstract class

            var s = new SmartCar();
            s.SelfDrive();
            s.Fly();



            
        }
    }
}
