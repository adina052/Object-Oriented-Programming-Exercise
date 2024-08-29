using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public abstract class Vehicle
    {
        private string licensePlate;
        private string make;
        private string model;
        protected double rentalPrice;


        // Constructor to initialize the attributes
        public Vehicle(string licensePlate, string make, string model, double rentalPrice) 
        { 
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }


        // Public methods to access the private attributes
        public string GetLicensePlate() { return licensePlate; }
        public string GetMake() { return make; }
        public string GetModel() { return model; }
        public double GetRentalPrice() { return rentalPrice; }


        // Abstract method to calculate rental cost, to be implemented by derived classes
        public abstract double CalculateRentalCost(int days);

    }
}
