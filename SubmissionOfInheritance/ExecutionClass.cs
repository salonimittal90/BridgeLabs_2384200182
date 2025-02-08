using SubmissionOfInheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SubmissionOfInheritance.Order;
using static SubmissionOfInheritance.Vehicle;

namespace SubmissionOfInheritance
{
    internal class ExecutionClass
    {
        public void CallingAnimal()
        {
            //Animal Hierarchy
            Animal dog = new Dog("Cheeru", 3);
            Animal cat = new Cat("Sandy", 2);
            Animal bird = new Bird("moony", 2);

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

        }
        public void CallingEmployee()
        {
            // instance using parent class reference
            Employee manager = new Manager("Ankita", 101, 100000, 8);
            Employee developer = new Developer("sita", 102, 50000, "C#");
            Employee intern = new Intern("Saloni", 103, 40000, "2 months");

            manager.DisplayDetails();
            developer.DisplayDetails();
            intern.DisplayDetails();
        }

        public void CallingVehicle()
        {
            // Creating an array of Vehicle objects
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(200, "Petrol", 6),
                new Truck(180, "Diesel", 5000),
                new Motorcycle(150, "Petrol", false)
            };

            //Calling methods dynamically
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine(); 
            }
        }

        public void CallingBook()
        {
            // Create an object of Author
            Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald",
                                      "American novelist, widely regarded as one of the greatest writers of the 20th century.");
            author.DisplayInfo();
        }

        public void CallingDevice()
        {
                // create an object of Thermostat (which is also a Device)
                Thermostat thermostat = new Thermostat(101, "Active", 22.5);

                // call DisplayStatus method
                thermostat.DisplayStatus();
        }

        public void CallingOrder()
        {
            Order order = new Order(1001, DateTime.Now);
            order.DisplayOrderDetails();
            Console.WriteLine("\n");

            // Order shipped
            ShippedOrder shippedOrder = new ShippedOrder(1002, DateTime.Now.AddDays(-3), "TRK123456");
            shippedOrder.DisplayOrderDetails();
            Console.WriteLine("\n");

            // Order delivered
            DeliveredOrder deliveredOrder = new DeliveredOrder(1003, DateTime.Now.AddDays(-7), "TRK987654", DateTime.Now.AddDays(-2));
            deliveredOrder.DisplayOrderDetails();

        }
        public void CallingCourse()
        {
            // Free Course
            Course freeCourse = new Course("C# Basics", 4);
            freeCourse.DisplayCourseInfo();
            Console.WriteLine("\n");

            // Online Course
            OnlineCourse onlineCourse = new OnlineCourse("Python for Data Science", 8, "Udemy", true);
            onlineCourse.DisplayCourseInfo();
            Console.WriteLine("\n");

            // Paid Online Course
            PaidOnlineCourse paidCourse = new PaidOnlineCourse("Full-Stack Web Development", 12, "Coursera", false, 299.99, 20);
            paidCourse.DisplayCourseInfo();
        }
        public void CallingBankAccount()
        {
            // Creating objects of different account types
            SavingsAccount savings = new SavingsAccount("S12345", 5000.75, 3.5);
            CheckingAccount checking = new CheckingAccount("C67890", 1500.50, 1000);
            FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD11223", 10000, 24);

            // Displaying account information
            savings.DisplayAccountType();
            checking.DisplayAccountType();
            fixedDeposit.DisplayAccountType();
        }

        public void CallingPerson()
        {
            // Creating objects of different roles
            Teacher teacher = new Teacher("Mr. Sharma", 40, "Mathematics");
            Student student = new Student("Aryan", 16, "10th Grade");
            Staff staff = new Staff("Mrs. Kapoor", 35, "Administration");

            // Displaying role-specific information
            teacher.DisplayRole();
            student.DisplayRole();
            staff.DisplayRole();
        }

        public void CallingRestaurantPerson()
        {
            // Creating objects of Chef and Waiter
            Chef chef = new Chef("Gordon Ramsay", 101);
            Waiter waiter = new Waiter("John Doe", 202);

            // Displaying details
            Console.WriteLine("\n--- Chef Details ---");
            chef.DisplayInfo();
            chef.PerformDuties();

            Console.WriteLine("\n--- Waiter Details ---");
            waiter.DisplayInfo();
            waiter.PerformDuties();

        }
        public void CallingBaseVihicle()
        {
            // Creating objects of ElectricVehicle and PetrolVehicle
            ElectricVehicle tesla = new ElectricVehicle(200, "Tesla Model S");
            PetrolVehicle mustang = new PetrolVehicle(250, "Ford Mustang");

            Console.WriteLine("\n--- Electric Vehicle Details ---");
            tesla.DisplayInfo();
            tesla.Charge();

            Console.WriteLine("\n--- Petrol Vehicle Details ---");
            mustang.DisplayInfo();
            mustang.Refuel();
        }
    }
 }

