using System;
namespace Factory_Pattern_Exercise
{

    public interface IVehicle
    {
        // Basee Properties
        public int AmountOfWheels { get; set; }
        public bool ForRacing { get; set; }
        // Stubbed out Base Method
        public void Drive();
    }
}


