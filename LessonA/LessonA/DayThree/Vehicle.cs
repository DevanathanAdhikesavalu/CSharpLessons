using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayThree
{
    internal class Vehicle
    {
        public Vehicle() {
            Console.WriteLine("Vehicle constructor");
        }
        public void Start()
        {
            Console.WriteLine("vehicle started");
        }
    }
    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
    class VehicleTester
    {
        public static void Testone()
        {
            Vehicle tester = new Car();
            tester.Start();
        }
    }

}
