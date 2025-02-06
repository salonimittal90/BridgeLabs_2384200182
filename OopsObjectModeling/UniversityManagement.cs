using System;
using System.Collections.Generic;

namespace UniversityManagementSystem
{
    // Course Class (Independent, Association with Student, Aggregation with Professor)
    class Course
    {
        public string CourseName { get; set; }
        public List<Student> EnrolledStudents { get; set; }  // Association: Students enroll in Courses
        public Professor AssignedProfessor { get; set; }  // Aggregation: Course is taught by a Professor

        public Course(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<Student>();
        }

        //Add this method to assign a professor to a course
        public void AssignProfessor(Professor professor)
        {
            AssignedProfessor = professor;
            professor.AssignCourse(this);  // Aggregation: Link the professor to this course
        }
    }
    // Student Class (Independent, Association with Course)
    class Student
    {
        public string StudentName { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public Student(string name)
        {
            StudentName = name;
            EnrolledCourses = new List<Course>();
        }

        public void EnrollCourse(Course course)
        {
            if (!EnrolledCourses.Contains(course))  // Prevent duplicate enrollments
                EnrolledCourses.Add(course);
        }

        //Add this method to display student details
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"\nStudent: {StudentName}");
            Console.WriteLine("Enrolled Courses:");
            if (EnrolledCourses.Count == 0)
                Console.WriteLine("   No courses enrolled.");
            else
                foreach (var course in EnrolledCourses)
                    Console.WriteLine($"   - {course.CourseName}");
        }
    }
    // Professor Class (Aggregation with Course)
    class Professor
    {
        public string ProfessorName { get; set; }
        public List<Course> AssignedCourses { get; set; }

        public Professor(string name)
        {
            ProfessorName = name;
            AssignedCourses = new List<Course>();
        }

        // Method to assign a course
        public void AssignCourse(Course course)
        {
            if (!AssignedCourses.Contains(course))  // Prevent duplicate assignments
                AssignedCourses.Add(course);
        }

        // Display professor details and assigned courses
        public void DisplayProfessorInfo()
        {
            Console.WriteLine($"\nProfessor: {ProfessorName}");
            Console.WriteLine("Assigned Courses:");
            if (AssignedCourses.Count == 0)
                Console.WriteLine("   No courses assigned.");
            else
                foreach (var course in AssignedCourses)
                    Console.WriteLine($"   - {course.CourseName}");
        }
    }
}

