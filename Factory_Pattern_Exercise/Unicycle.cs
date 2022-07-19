using System;
namespace Factory_Pattern_Exercise
{
    public class Unicycle : IVehicle
    {
        public Unicycle()
        {
        }

        public int AmountOfWheels { get; set;  }
        public bool ForRacing { get; set; }

        public void Drive()
        {
            Console.WriteLine("You seriously want to be in a circus hugh?");
        }
    }
}

