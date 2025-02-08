using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfInheritance
{
    //Base class Employee
    public class Employee
    {
        //Attributes
        private string EmpName;
        private int EmpId;
        private double EmpSalary;

        //Constructor
        public Employee(string empName, int empId, double empSalary)
        {
            this.EmpName = empName;
            this.EmpId = empId;
            this.EmpSalary = empSalary;
        }
        //Method to display the details of an employee
        public virtual void DisplayDetails()
        {
            Console.WriteLine("----The details of the Employee ----");
            Console.WriteLine("Name : " + EmpName);
            Console.WriteLine("Id : " + EmpId);
            Console.WriteLine("Salary : " + EmpSalary);
        }
    }

    //Subclass Manager
    class Manager : Employee
    {
        private int TeamSize;
        public Manager(string empName, int empId, double empSalary, int teamSize) : base(empName, empId, empSalary)
        {
            this.TeamSize = teamSize;
        }

        //Overriding the method 

        public override void DisplayDetails()
        {
            //call the parent class method
            base.DisplayDetails();
            Console.WriteLine("Team Size : " + TeamSize);

        }
    }

    //Subclass Developer
    class Developer : Employee
    {
        private string ProgrammingLanguage;
        public Developer(string empName, int empId, double empSalary, string programmingLanguage) : base(empName, empId, empSalary)
        {
            this.ProgrammingLanguage = programmingLanguage;
        }

        //Overriding the method 

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Programming Language : " + ProgrammingLanguage);
        }
    }

    //Subclass Intern
    class Intern : Employee
    {
        string InternshipDuration;
        public Intern(string empName, int empId, double empSalary, string internshipDuration) : base(empName, empId, empSalary)
        {
            this.InternshipDuration = internshipDuration;
        }

        //Overriding the method 

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Internship Duration : " + InternshipDuration);
        }
    }
}