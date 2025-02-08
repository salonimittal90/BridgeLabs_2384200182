using System;

namespace SubmissionOfInheritance
{
    public class Course
    {
         string CourseName;
        int Duration;

        // Constructor
        public Course(string courseName, int duration)
        {
            this.CourseName = courseName;
            this.Duration = duration;
        }

        // Virtual method to display course info
        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} weeks");
        }
    }

    // Subclass OnlineCourse
    public class OnlineCourse : Course
    {
        string Platform;
        bool IsRecorded;

        // Constructor
        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            this.Platform = platform;
            this.IsRecorded = isRecorded;
        }

        // Overriding method 
        public override void DisplayCourseInfo()
        {
            base.DisplayCourseInfo();
            Console.WriteLine($"Platform: {Platform}");
            Console.WriteLine($"Recorded: {(IsRecorded ? "Yes" : "No")}");
        }
    }

    // Subclass PaidOnlineCourse
    public class PaidOnlineCourse : OnlineCourse
    {
        protected double Fee;
        protected double Discount;

        // Constructor
        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            this.Fee = fee;
            this.Discount = discount;
        }

        // Method to calculate final price after discount
        public double GetFinalPrice()
        {
            return Fee - (Fee * Discount / 100);
        }

        // Overriding method of base class
        public override void DisplayCourseInfo()
        {
            base.DisplayCourseInfo();
            Console.WriteLine($"Fee: ${Fee}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Final Price after Discount: ${GetFinalPrice()}");
        }
    }
}
 