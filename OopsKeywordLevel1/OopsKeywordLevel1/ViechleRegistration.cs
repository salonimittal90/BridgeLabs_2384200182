using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class ViechleRegistration
    {
        // Static variable shared by all vehicles
        private static double RegistrationFee = 500.00; // Default registration fee

        // Readonly variable to ensure RegistrationNumber is immutable
        private readonly string RegistrationNumber;
        private string OwnerName;
        private string VehicleType;

        // Constructor using 'this' keyword
        public ViechleRegistration(string ownerName, string vehicleType, string registrationNumber)
        {
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            this.RegistrationNumber = registrationNumber;
        }

        // Static method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine("Registration fee updated to: $" + RegistrationFee);
        }

        // Method to display vehicle details, using 'is' operator
        public void DisplayVehicleDetails()
        {
            if (this is ViechleRegistration)
            {
                Console.WriteLine("\nVehicle Registration Details:");
                Console.WriteLine("Owner: " + this.OwnerName);
                Console.WriteLine("Vehicle Type: " + this.VehicleType);
                Console.WriteLine("Registration Number: " + this.RegistrationNumber);
                Console.WriteLine("Registration Fee: $" + RegistrationFee);
            }
            else
            {
                Console.WriteLine("Invalid vehicle object.");
            }
        }
    }
}
