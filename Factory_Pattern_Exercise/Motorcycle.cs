using System;
namespace Factory_Pattern_Exercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        // Inherited Method
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle");
        }
    }
}

