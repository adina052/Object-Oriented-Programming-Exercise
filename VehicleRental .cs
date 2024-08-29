using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class VehicleRental
    {
        public void RunRentalProcess()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("548958652", "Mazda", "R5", 550, "regular"));
            vehicles.Add(new Truck("215485674", "Volvo", "SEW", 1100, 2000));

            // Vehicle rental
            List<Vehicle> tempVehicle = new List<Vehicle>(vehicles);
            RegularCustomer regularCustomer = new RegularCustomer("Moshe Levi", tempVehicle);
            regularCustomer.RentVehicle(new Car("786529856", "Tesla", "T5", 745, "new"), 4);
            tempVehicle = vehicles;
            CorporateCustomer corporateCustomer = new CorporateCustomer("Osem", tempVehicle);
            corporateCustomer.RentVehicle(new Truck("951274852", "Toyota", "QAD", 2500, 2100), 9);

            // Customer list
            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(regularCustomer);
            customers.Add(corporateCustomer);

            string name;
            string vehicletype;

            // Going over the customers and printing the details of the vehicles rented by customer
            foreach (var customer in customers)
            {
                Console.WriteLine("------------------------------------------------");

                // Print customer name or company name
                name = customer is RegularCustomer ? $"Customer Name: {customer.GetName()}" :
                     $"Company Name: {customer.GetName()}";
                Console.WriteLine(name);

                foreach (var rentedVehicles in customer.GetRentedVehicles())
                {
                    Console.WriteLine("********************************************");
                    vehicletype = rentedVehicles is Car ? "Car" : "Truck";
                    Console.WriteLine("Vehicle Type: " + vehicletype);
                    Console.WriteLine("License Plate: " + rentedVehicles.GetLicensePlate());
                    Console.WriteLine("Make: " + rentedVehicles.GetMake());
                    Console.WriteLine("Model: " + rentedVehicles.GetModel());
                    Console.WriteLine("Rental Price: " + rentedVehicles.GetRentalPrice());
                    Console.WriteLine("Rental Cost Included: " + rentedVehicles.CalculateRentalCost(5));
                }
            }
        }
    }
}
     
