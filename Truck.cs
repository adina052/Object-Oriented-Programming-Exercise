using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Truck:Vehicle
    {
        private int capacity;


        // Constructor to initialize the attributes
        public Truck(string licensePlate, string make, string model, double rentalPrice,int capacity)
            :base(licensePlate,make,model,rentalPrice)
        {
            this.capacity = capacity;
        }


        // Override the abstract method to calculate rental cost for trucks
        public override double CalculateRentalCost(int days)
        {
            return (days * GetRentalPrice()) + capacity;
        }
    }
}      

