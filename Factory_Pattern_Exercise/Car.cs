using System;
namespace Factory_Pattern_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public int AmountOfWheels { get; set; } = 4;
        public bool ForRacing { get; set; } = true;

        // Inherited Method
        public void Drive()
        {
            Console.WriteLine("Building a new Car");
        }
    }
}

