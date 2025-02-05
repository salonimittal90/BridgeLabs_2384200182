using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class EmployeeManagement
    {
        private static string companyName = "Capgemini";
        private static int EmployeeCount = 0;

        private readonly int id;
        private string name;
        private string designation;

        public EmployeeManagement(string name, int id, string designation)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            EmployeeCount++; // Increment employee count
        }

        // Static method to display total employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + EmployeeCount);
        }


        public void DisplayEmployeeDetails()
        {
            if (this is EmployeeManagement)
            {
                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("Name: " + this.name);
                Console.WriteLine("ID: " + this.id);
                Console.WriteLine("Designation: " + this.designation);
            }
            else
            {
                Console.WriteLine("Invalid employee object.");
            }

        }
    }
}

