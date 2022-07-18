using System;
namespace Factory_Pattern_Exercise
{
    public static class VehicleFactory
    {

        // Method to create new vehicle based on user input
        public static IVehicle GetVehicle(string amountOfTires)
        {
            switch (amountOfTires.ToLower())
            {
                case "two wheels":
                    return new Motorcycle();
                   
                case "four wheels":
                    return new Car();

                default:
                    return new Car();
            }
        }
    }
}
