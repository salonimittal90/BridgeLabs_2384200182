using System;
using System.Collections.Generic;


namespace SubmissionOfEncapsulation
{
    public class ExecutionClass
    {
        public void CallingEmployee()
        {
            List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Alice", 50000, 5000),
            new PartTimeEmployee(2, "Bob", 200, 20)
        };

            employees[0].AssignDepartment("IT");
            employees[1].AssignDepartment("HR");

            // Polymorphism - Process all employees using Employee reference
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }
        }
        public void CallingProduct()
        {
            {
                List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 50000),
            new Clothing(102, "T-Shirt", 1000),
            new Groceries(103, "Rice", 500)
        };

                // Processing all products using Polymorphism
                foreach (Product prod in products)
                {
                    double discount = prod.CalculateDiscount();
                    double tax = 0;

                    // Checking if Product is Taxable
                    if (prod is ITaxable taxableProduct)
                    {
                        tax = taxableProduct.CalculateTax();
                        Console.WriteLine($"{taxableProduct.GetTaxDetails()}");
                    }

                    double finalPrice = prod.Price + tax - discount;
                    Console.WriteLine($"Final Price of {prod.Name}: {finalPrice:C}\n");
                }
            }
        }
        public void CallingVehicle()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("MH12AB1234", 1500, "CAR-INS-001"),
            new Bike("MH14XY5678", 500, "BIKE-INS-002"),
            new Truck("MH10TR8901", 2500, "TRUCK-INS-003")
        };

            int rentalDays = 5;

            // Processing all vehicles using Polymorphism
            foreach (Vehicle v in vehicles)
            {
                v.DisplayDetails(rentalDays);
                Console.WriteLine(v.GetInsuranceDetails());
                Console.WriteLine("----------------------------------");
            }
        }
        public void CallingBankAccount()
        {
            List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount(101, "Alice", 5000, 5),
            new CurrentAccount(102, "Bob", 2000)
        };

            // Process all accounts dynamically
            foreach (BankAccount acc in accounts)
            {
                acc.DisplayDetails();
                acc.Deposit(1000);
                acc.Withdraw(500);
                acc.ApplyForLoan(3000);
                Console.WriteLine("----------------------------------");
            }
        }
        public void CallingLibraryItem()
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book(101, "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine(102, "National Geographic", "NatGeo Team"),
            new DVD(103, "Interstellar", "Christopher Nolan")
        };

            // Processing all library items using Polymorphism
            foreach (LibraryItem item in libraryItems)
            {
                item.GetItemDetails();
                item.ReserveItem();
                item.BorrowItem("John Doe");
                Console.WriteLine($"Availability: {(item.CheckAvailability() ? "Available" : "Not Available")}");
                Console.WriteLine("----------------------------------");
            }
        }
        public void CallingFoodItem()
        {
            {
                List<FoodItem> foodItems = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

                // Processing all food items using Polymorphism
                foreach (FoodItem item in foodItems)
                {
                    item.GetItemDetails();
                    item.ApplyDiscount(10);
                    Console.WriteLine(item.GetDiscountDetails());
                    Console.WriteLine("----------------------------------");
                }
            }
        }
        public void CallingPatient()
        {
            List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Alice", 30, "Pneumonia", 5, 2000),
            new OutPatient(102, "Bob", 45, "Fever", 500)
        };

            // Processing all patients using Polymorphism
            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: {patient.CalculateBill():C}");
                patient.AddRecord("Routine Checkup");
                patient.ViewRecords();
                Console.WriteLine("----------------------------------");
            }
        }
        public void CallingRide()
        {
            List<Ride> rides = new List<Ride>
        {
            new Cab(101, "Rajesh", 15, "Connaught Place"),
            new Scooter(102, "Amit", 8, "Khan Market"),
            new Auto(103, "Suraj", 10, "Karol Bagh")
        };

            double rideDistance = 10;  // Example distance in km

            // Processing all rides using Polymorphism
            foreach (Ride r in rides)
            {
                r.GetRideDetails();
                Console.WriteLine($"Fare for {rideDistance} km: {r.CalculateFare(rideDistance):C}");
                r.UpdateLocation("New Delhi Railway Station");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
