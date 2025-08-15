using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

            if (int.TryParse(Console.ReadLine(), out int wheelCount))
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(wheelCount);
                vehicle.Drive();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            
        }
    }
}