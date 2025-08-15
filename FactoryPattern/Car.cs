using System;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialouge();
            Console.WriteLine("The Car is driving! Woo!");
        }
    }
}