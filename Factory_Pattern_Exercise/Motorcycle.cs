using System;
namespace Factory_Pattern_Exercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public int AmountOfWheels { get; set; } = 2;
        public bool ForRacing { get; set; } = true;

        // Inherited Method
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle");
        }
    }
}

