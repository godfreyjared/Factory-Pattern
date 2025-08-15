using System;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialouge();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("Vrooooooom!");
        }
    }
}