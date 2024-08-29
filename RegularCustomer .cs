using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class RegularCustomer : ICustomer
    {
        private string name;

        // List to store rented vehicles
        private List<Vehicle> rentedVehicles = new List<Vehicle>();


        // Constructor to initialize the attributes
        public RegularCustomer(string name, List<Vehicle> rentedVehicles)
        {
            this.name = name;
            this.rentedVehicles = rentedVehicles;
        }
        
        public string GetName() { return name; }
        public void RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);

            //  Print the rental cost
            Console.WriteLine("the price for rent to regular customer: " + (vehicle.CalculateRentalCost(days)));
        }
        public List<Vehicle> GetRentedVehicles()
        {
            return rentedVehicles; 
        }
    }
}
