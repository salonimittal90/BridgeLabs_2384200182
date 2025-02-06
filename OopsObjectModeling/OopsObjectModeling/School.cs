using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsObjectModeling.Course;

namespace OopsObjectModeling
{
    // Course Class (Independent)
    class Course
    {
        public string CourseName;
        public List<Student> EnrolledStudents;  // Stores students enrolled in this course

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);  // Add student to course's student list
        }

        public void ShowEnrolledStudents()
        {
            Console.WriteLine($"Students enrolled in {CourseName}:");
            if (EnrolledStudents.Count == 0)
            {
                Console.WriteLine("   No students enrolled.");
            }
            else
            {
                foreach (var student in EnrolledStudents)
                {
                    Console.WriteLine($"   - {student.Name}");
                }
            }
        }
    }

    // Student Class (Independent, Associated with Courses)
    class Student
    {
        public string Name;
        public List<Course> Courses;  // Stores courses the student is enrolled in

        public Student(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
        }

        public void EnrollCourse(Course course)
        {
            Courses.Add(course);  // Add course to student's course list
            course.EnrollStudent(this);  // Ensure bidirectional association
        }

        public void ShowCourses()
        {
            Console.WriteLine($"{Name} is enrolled in:");
            if (Courses.Count == 0)
            {
                Console.WriteLine("   No courses enrolled.");
            }
            else
            {
                foreach (var course in Courses)
                {
                    Console.WriteLine($"   - {course.CourseName}");
                }
            }
        }
    }

    // School Class (Aggregation with Students)
    class School
    {
        public string SchoolName;
        public List<Student> Students;  // Aggregation: Students exist outside School

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Students in {SchoolName}:");
            if (Students.Count == 0)
            {
                Console.WriteLine("   No students found.");
            }
            else
            {
                foreach (var student in Students)
                {
                    Console.WriteLine($"   - {student.Name}");
                }
            }
        }
    }
}

