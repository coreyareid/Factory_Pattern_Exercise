using System;
namespace Factory_Pattern_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        // Inherited Method
        public void Drive()
        {
            Console.WriteLine("Building a new Car");
        }
    }
}

