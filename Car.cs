using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Car : Vehicle
    {
        private string type;

        // Constructor to initialize the attributes
        public Car(string licensePlate, string make, string model, double rentalPrice, string type)
            : base(licensePlate, make, model, rentalPrice)
        {
            this.type = type;
        }


        // Override the abstract method to calculate rental cost for cars
        public override double CalculateRentalCost(int days)
        {
            return GetRentalPrice() * days;
        }
    }
}       

