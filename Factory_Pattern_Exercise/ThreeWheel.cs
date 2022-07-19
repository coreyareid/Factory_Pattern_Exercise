using System;
namespace Factory_Pattern_Exercise
{
    public class ThreeWheel : IVehicle
    {
        public ThreeWheel()
        {
        }

        public int AmountOfWheels { get; set; } = 3;
        public bool ForRacing { get; set; } = false;

        public void Drive()
        {
            Console.WriteLine("Building a three Wheeler");
        }
    }
}

