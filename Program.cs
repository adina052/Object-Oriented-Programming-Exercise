using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of VehicleRental to handle the rental process
            VehicleRental rentalSystem = new VehicleRental();

            // Run the rental process, which includes creating vehicles, customers, 
            // and demonstrating the rental of vehicles with cost calculations
            rentalSystem.RunRentalProcess();

         
        }
    }
}
