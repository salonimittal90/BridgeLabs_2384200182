using System;

namespace SubmissionOfInheritance
{
    public class Person
    {
            string Name;
            int Age;

            // Constructor
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            // Method to display person information
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
            }
        }

        // Subclass (Teacher)
        public class Teacher : Person
        {
            string Subject;

            // Constructor
            public Teacher(string name, int age, string subject)
                : base(name, age)
            {
                this.Subject = subject;
            }

            // Overriding method to display role
            public void DisplayRole()
            {
                Console.WriteLine("\n--- Teacher Information ---");
                DisplayInfo();
                Console.WriteLine($"Teaches: {Subject}");
            }
        }

        // Subclass (Student)
        public class Student : Person
        {
            string Grade;

            // Constructor
            public Student(string name, int age, string grade)
                : base(name, age)
            {
                this.Grade = grade;
            }

            // Overriding method to display role
            public void DisplayRole()
            {
                Console.WriteLine("\n--- Student Information ---");
                DisplayInfo();
                Console.WriteLine($"Grade: {Grade}");
            }
        }

        // Subclass (Staff)
        public class Staff : Person
        {
            string Department;

            // Constructor
            public Staff(string name, int age, string department)
                : base(name, age)
            {
                this.Department = department;
            }

            // Overriding method to display role
            public void DisplayRole()
            {
                Console.WriteLine("\n--- Staff Information ---");
                DisplayInfo();
                Console.WriteLine($"Department: {Department}");
            }
        }
    }
