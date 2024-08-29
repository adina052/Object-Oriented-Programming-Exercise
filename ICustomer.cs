using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public interface ICustomer
    {
        // Method to get the name of the customer
        string GetName();


        // Method to process the rental of a vehicle
        void RentVehicle(Vehicle vehicle, int days);


        // Method to get a list of vehicles rented by the customer
        List<Vehicle> GetRentedVehicles();
    }
}
