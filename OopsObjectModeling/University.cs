using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    // Faculty class (Aggregation: Can exist outside a Department)
    class Faculty
    {
        public string Name;
        public string Subject;

        public Faculty(string name, string subject)
        {
            this.Name = name;
            this.Subject = subject;
        }

        public void DisplayFacultyInfo()
        {
            Console.WriteLine($"   - {Name}, {Subject}");
        }
    }

    // Department class (Composition: Exists only within University)
    class Department
    {
        public string DepartmentName;
        public List<Faculty> Faculties;  // Aggregation: Faculties can exist independently of the Department

        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
            Faculties = new List<Faculty>();  // Initialize the faculties list
        }

        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);  // Add a faculty to the department
        }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            if (Faculties.Count == 0)
            {
                Console.WriteLine("   No faculty assigned.");
            }
            else
            {
                foreach (var faculty in Faculties)
                {
                    faculty.DisplayFacultyInfo();
                }
            }
        }
    }

    // University class (Composition: University owns Departments)
    class University
    {
        public string UniversityName;
        public List<Department> Departments;  // Composition: Departments belong to the University

        public University(string universityName)
        {
            this.UniversityName = universityName;
            Departments = new List<Department>();  // Initialize the departments list
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);  // Add a department to the university
        }

        // Destructor to delete the University and all its Departments
        ~University()
        {
            Console.WriteLine($"\nDeleting {UniversityName} and all associated departments...");
            Departments.Clear();  // Deleting all departments
        }

        public void DisplayUniversityInfo()
        {
            Console.WriteLine($"University: {UniversityName}");
            if (Departments.Count == 0)
            {
                Console.WriteLine("   No departments available.");
            }
            else
            {
                foreach (var dept in Departments)
                {
                    dept.DisplayDepartmentInfo();
                }
            }
        }
    }
}
