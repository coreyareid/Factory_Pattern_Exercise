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
                case "one wheel":
                case "1":
                    return new Unicycle();

                case "two wheels":
                case "2":
                    return new Motorcycle();

                case "three wheels":
                case "3":
                    return new ThreeWheel();
                   
                case "four wheels":
                case "4":
                    return new Car();

                default:
                    return new Car();
            }
        }
    }
}
