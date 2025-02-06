using OOPSConcept;
using System;
using UniversityManagementSystem;
using UniversitySystem;

namespace OopsObjectModeling
{
    public class ExecutionClass
    {
        //method for Question1
        public void CallingLibrary()
        {

            //create the object of book class
            Book book1 = new Book("saloni", "book communication");
            Book book2 = new Book("jyoti", "book living");


            //create the object of Library class
            Library library1 = new Library("state library");
            Library library2 = new Library("city library");


            //call the object of Library class and provide the refference of book as an arguments
            library1.AddBook(book1);
            library1.AddBook(book2);
            library2.AddBook(book1);

            //display the books available in the each library
            library2.DisplayLibrary();
            library1.DisplayLibrary();
        }

        public void CallingBank()
        {
            //create the method of bank class 
            Bank sbi = new Bank("SBI");


            //creating customers method
            Customer c1 = new Customer("saloni");
            Customer c2 = new Customer("Anju");

            //call openAccount method
            sbi.OpenAccount(c1, "Saving", 2000);
            sbi.OpenAccount(c1, "current", 5000);
            sbi.OpenAccount(c2, "current", 4000);


            //call the view balance method
            c1.ViewBalance();
            c2.ViewBalance();
        }

        public void CallingCompany()
        {
            Company techCorp = new Company("TechCorp");

            // Displaying Company Details
            techCorp.Display();

            // Simulating deletion of Company (Composition behavior)
            Console.WriteLine("\nCompany is now being deleted...");
            techCorp = null;  // Deleting the company object
            GC.Collect();  // Forcing Garbage Collection to call destructor

            Console.WriteLine("End of Program.");
        }

        public void CallingSchool()
        {
            // Creating School
            School mySchool = new School("Greenwood High");

            // Creating Students (Aggregation)
            Student s1 = new Student("Saloni");
            Student s2 = new Student("Anju");

            // Adding Students to School (Aggregation)
            mySchool.AddStudent(s1);
            mySchool.AddStudent(s2);

            // Creating Courses (Independent)
            Course c1 = new Course("Math");
            Course c2 = new Course("Science");
            Course c3 = new Course("English");

            // Enrolling Students in Courses (Association)
            s1.EnrollCourse(c1);
            s1.EnrollCourse(c2);
            s2.EnrollCourse(c2);
            s2.EnrollCourse(c3);

            // Displaying School Students
            mySchool.ShowStudents();
            Console.WriteLine();

            // Displaying Student Enrollments
            s1.ShowCourses();
            s2.ShowCourses();
            Console.WriteLine();

            // Displaying Course Enrollments
            c1.ShowEnrolledStudents();
            c2.ShowEnrolledStudents();
            c3.ShowEnrolledStudents();
        }

        public void CallingUniversity()
        {
            // Creating Faculty members (Aggregation)
            Faculty f1 = new Faculty("Dr. Sharma", "Physics");
            Faculty f2 = new Faculty("Dr. Gupta", "Mathematics");
            Faculty f3 = new Faculty("Dr. Soni", "Computer Science");

            // Creating Departments with new names (Composition)
            // Use fully qualified class names
            UniversitySystem.Department d1 = new UniversitySystem.Department("Physics and Astronomy Department");
            UniversitySystem.Department d2 = new UniversitySystem.Department("Applied Mathematics Department");


            // Adding Faculty to Departments (Aggregation)
            d1.AddFaculty(f1);
            d2.AddFaculty(f2);
            d2.AddFaculty(f3);

            // Creating a University (Composition)
            University myUniversity = new University("Greenwich University");

            // Adding Departments to University (Composition)
            myUniversity.AddDepartment(d1);
            myUniversity.AddDepartment(d2);

            // Displaying University Info
            myUniversity.DisplayUniversityInfo();

            // Simulating University deletion (Destructor will be called)
            Console.WriteLine("\nDeleting University...");
            myUniversity = null;  // University object is deleted, calling the destructor
            GC.Collect();  // Forcing Garbage Collection to call destructor

            Console.WriteLine("End of Program.");
        }

        public void CallingPaitentHospital()
        {
            // Create the hospital
            Hospital hospital = new Hospital("Delhi AIIMS");

            // Create doctors
            Doctor doctor1 = new Doctor("Dr. Pranjal", "Surgery");
            Doctor doctor2 = new Doctor("Dr. Vijay", "Ortho");

            // Add doctors to the hospital
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            // Create patients
            Patient patient1 = new Patient("Vaibhav");
            Patient patient2 = new Patient("Ankit");

            // Add patients to the hospital
            hospital.AddPatient(patient1);
            hospital.AddPatient(patient2);

            // Patients consult with doctors
            patient1.ConsultWithDoctor(doctor1);
            patient2.ConsultWithDoctor(doctor1);
            patient1.ConsultWithDoctor(doctor2);

            // Show the patients consulted by each doctor
            doctor1.ShowPatients();
            doctor2.ShowPatients();

            // Show the list of all doctors and patients in the hospital
            hospital.ShowHospitalDetails();
        }

        public void CallingEcommerce()
        {
            // Creating products
            Product product1 = new Product("Laptop", 1000);
            Product product2 = new Product("Smartphone", 800);
            Product product3 = new Product("Headphones", 150);

            // Creating first order
            Order order1 = new Order("ORD123");
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            // Creating customer
            EcommerceCustomer customer1 = new EcommerceCustomer("John Doe", "john@example.com");

            // Customer places first order
            customer1.PlaceOrder(order1);

            // Creating second order
            Order order2 = new Order("ORD124");
            order2.AddProduct(product3);

            // Customer places second order
            customer1.PlaceOrder(order2);

            // Display customer's orders and details
            customer1.DisplayCustomerOrders();
        }

        public void CallingUniversityManagement()
        {
            // Creating Students
            Student s1 = new Student("Alice");
            Student s2 = new Student("Bob");

            // Creating Professors
            Professor p1 = new Professor("Dr. Smith");
            Professor p2 = new Professor("Dr. Johnson");

            // Creating Courses
            Course c1 = new Course("Computer Science");
            Course c2 = new Course("Mathematics");

            // Students Enrolling in Courses
            c1.EnrollStudent(s1);
            c1.EnrollStudent(s2);
            c2.EnrollStudent(s1);

            // Assign Professors to Courses (Fix for CS1061 error)
            //c1.AssignProfessor(p1);
            //c2.AssignProfessor(p2);

            // Display Student Information (Fix for CS1061 error)
            //s1.DisplayStudentInfo();
           //s2.DisplayStudentInfo();
        }
    }
}