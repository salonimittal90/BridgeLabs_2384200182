using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class UniversityManagement
    {
        // Static variable shared across all students
        private static string UniversityName = "Global University";
        private static int StudentCount = 0; // Track total students enrolled

        // Readonly variable to ensure RollNumber is immutable
        private readonly int RollNumber;
        private string Name;
        private char Grade;

        // Constructor using 'this' keyword
        public UniversityManagement(string name, int rollNumber, char grade)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
            this.Grade = grade;
            StudentCount++; // Increment student count
        }

        // Static method to display total students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students Enrolled: " + StudentCount);
        }

        // Method to update student grade after validation
        public void UpdateGrade(char newGrade)
        {
            if (this is UniversityManagement)
            {
                this.Grade = newGrade;
                Console.WriteLine("Grade updated successfully for Roll Number: " + this.RollNumber);
            }
            else
            {
                Console.WriteLine("Invalid student object.");
            }
        }

        // Method to display student details, using 'is' operator
        public void DisplayStudentDetails()
        {
            if (this is UniversityManagement)
            {
                Console.WriteLine("\nStudent Details:");
                Console.WriteLine("Name: " + this.Name);
                Console.WriteLine("Roll Number: " + this.RollNumber);
                Console.WriteLine("Grade: " + this.Grade);
            }
            else
            {
                Console.WriteLine("Invalid student object.");
            }
        }
    }
}
