using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
   
    public class CorporateCustomer : ICustomer
    {
        //Const attribute discount for corporate customer
        const double discount = 0.9;


        private string companyName;


        // List to store rented vehicles
        private List<Vehicle> rentedVehicles = new List<Vehicle>();


        // Constructor to initialize the attributes
        public CorporateCustomer(string companyName,List<Vehicle> rentedVehicles)
        {
            this.companyName = companyName;
            this.rentedVehicles = rentedVehicles;
        }
        public string GetName() { return companyName; }


        // Override the rentVehicle method with a discount
        public void RentVehicle(Vehicle vehicle, int days)
        {
            rentedVehicles.Add(vehicle);

            //  Print the calculate rental cost with a discount
            Console.WriteLine("the price for rent to corporate customer: " + (vehicle.CalculateRentalCost(days)* discount));
        }
        public List<Vehicle> GetRentedVehicles() { return rentedVehicles; }

    }
}
