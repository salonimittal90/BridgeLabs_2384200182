using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class ExecutionClass
    {
        public void CallingBankAccount()
        {
            BankAccount obj = new BankAccount(101, "saloni mittal", 5000);
            BankAccount.BankOperations(obj);
        }

        public void CallingLibraryManagement()
        {
            //Creating book objects
            LibraryManagement book1 = new LibraryManagement("C# Programming", "John Doe", "123-456-789");
            LibraryManagement book2 = new LibraryManagement("Data Structures", "Jane Smith", "987-654-321");

            // Displaying book details

            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }

        public void CallingEmployeeManagement()
        {
            // Creating employee objects
            EmployeeManagement emp1 = new EmployeeManagement("Alice Johnson", 101, "Software Engineer");
            EmployeeManagement emp2 = new EmployeeManagement("Bob Smith", 102, "Project Manager");

            // Display total employees
            EmployeeManagement.DisplayTotalEmployees();

            // Displaying employee details
            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
        }

        public void CallingShoppingCart()
        {
            // Updating discount for all products
            ShoppingCart.UpdateDiscount(15.0);

            // Creating product objects
            ShoppingCart product1 = new ShoppingCart(101, "Laptop", 1200.00, 2);
            ShoppingCart product2 = new ShoppingCart(102, "Smartphone", 800.00, 5);

            // Displaying product details
            product1.DisplayProductDetails();
            product2.DisplayProductDetails();

        }
        public void CallingUniversityManagement()
        {
            // Display total students before enrollment
            UniversityManagement.DisplayTotalStudents();

            // Creating student objects
            UniversityManagement student1 = new UniversityManagement("Saloni", 101, 'A');
            UniversityManagement student2 = new UniversityManagement("Jyoti", 102, 'B');

            // Display total students after enrollment
            UniversityManagement.DisplayTotalStudents();

            // Displaying student details
            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            // Updating student grade
            student2.UpdateGrade('A');

            // Display updated details
            student2.DisplayStudentDetails();

        }

        public void CallingVehileRegistration()
        {
            // Updating the registration fee
            ViechleRegistration.UpdateRegistrationFee(550.00);

            // Creating vehicle objects
            ViechleRegistration vehicle1 = new ViechleRegistration("Alice Johnson", "Car", "ABC123");
           ViechleRegistration vehicle2 = new ViechleRegistration("Bob Smith", "Motorcycle", "XYZ789");

            // Displaying vehicle details
             vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();


        }
        public void CallingHospitalManagement()
        {
            // Display total patients before admitting any
            HospitalManagement.GetTotalPatients();

            // Creating patient objects
            HospitalManagement patient1 = new HospitalManagement(101, "Sita", 30, "Flu");
            HospitalManagement patient2 = new HospitalManagement(102, "Gita", 45, "Fever");

            // Display total patients after admission
            HospitalManagement.GetTotalPatients();

            // Displaying patient details
            patient1.DisplayPatientDetails();
            patient2.DisplayPatientDetails();
        }

    }
}
