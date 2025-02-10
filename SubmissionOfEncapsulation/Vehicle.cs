using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfEncapsulation
{
    // Interface for Insurance Calculation
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Abstract Class for Vehicles
    abstract class Vehicle : IInsurable
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;
        private string insurancePolicyNumber;

        // Constructor
        public Vehicle(string number, string vType, double rate, string policyNumber)
        {
            this.vehicleNumber = number;
            this.type = vType;
            this.rentalRate = rate;
            this.insurancePolicyNumber = policyNumber;
        }

        // Encapsulation - Properties
        public string VehicleNumber { get { return vehicleNumber; } }
        public string Type { get { return type; } }
        public double RentalRate { get { return rentalRate; } }

        // Abstract Method for Rental Cost
        public abstract double CalculateRentalCost(int days);

        // Concrete Method to Display Details
        public void DisplayDetails(int days)
        {
            Console.WriteLine($"Vehicle: {Type}, Number: {VehicleNumber}, Rental Cost: {CalculateRentalCost(days):C}, Insurance Cost: {CalculateInsurance():C}");
        }

        // Interface Methods for Insurance
        public double CalculateInsurance()
        {
            return RentalRate * 0.1;  // 10% of Rental Rate
        }

        public string GetInsuranceDetails()
        {
            return $"Insurance Policy: {insurancePolicyNumber}, Insurance Amount: {CalculateInsurance():C}";
        }
    }

    // Car Class
    class Car : Vehicle
    {
        public Car(string number, double rate, string policy) : base(number, "Car", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;  // Simple per-day charge
        }
    }

    // Bike Class
    class Bike : Vehicle
    {
        public Bike(string number, double rate, string policy) : base(number, "Bike", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) - 50;  // ₹50 Discount for Bikes
        }
    }

    // Truck Class
    class Truck : Vehicle
    {
        public Truck(string number, double rate, string policy) : base(number, "Truck", rate, policy) { }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 500;  // Extra ₹500 for Trucks
        }
    }

}
