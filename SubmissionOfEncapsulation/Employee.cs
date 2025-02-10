using System;
using System.Collections.Generic;


namespace SubmissionOfEncapsulation
{
    interface IDepartment
    {
        void AssignDepartment(string dept);
        string GetDepartmentDetails();
    }

    // Abstract class Employee
    abstract class Employee : IDepartment
    {
        private int employeeId;
        private string name;
        private double baseSalary;
        private string department;

        // Constructor
        public Employee(int id, string empName, double salary)
        {
            this.employeeId = id;
            this.name = empName;
            this.baseSalary = salary;
        }

        // Encapsulation - Properties
        public int EmployeeId { get { return employeeId; } }
        public string Name { get { return name; } }
        public double BaseSalary { get { return baseSalary; } }

        // Abstract Method
        public abstract double CalculateSalary();

        // Concrete Method
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}, Department: {GetDepartmentDetails()}");
        }

        // Interface Methods
        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return department ?? "Not Assigned";
        }
    }

    // Full-Time Employee Class
    class FullTimeEmployee : Employee
    {
        private double bonus;

        public FullTimeEmployee(int id, string name, double salary, double bonus)
            : base(id, name, salary)
        {
            this.bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + bonus;  // Fixed salary + bonus
        }
    }

    // Part-Time Employee Class
    class PartTimeEmployee : Employee
    {
        private int workingHours;
        private double hourlyRate;

        public PartTimeEmployee(int id, string name, double rate, int hours)
            : base(id, name, 0)  // BaseSalary not used for part-time employees
        {
            this.hourlyRate = rate;
            this.workingHours = hours;
        }

        public override double CalculateSalary()
        {
            return workingHours * hourlyRate;  // Pay based on hours worked
        }
    }
}