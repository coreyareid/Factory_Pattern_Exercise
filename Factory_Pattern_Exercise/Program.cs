using Factory_Pattern_Exercise;


Console.WriteLine("How many wheels do you want on your vehicle? \"Don\'t type 1\" 2 wheels, 3 wheels, or 4 wheels?");

// Variable of user input
string userInput = Console.ReadLine();

// calls method to create vehicle based on user input and stores variable to call the drive method.
IVehicle tires = VehicleFactory.GetVehicle(userInput);

//Stubbed Out Method that lets you know what vehicle is being created based on the called class.
tires.Drive();






