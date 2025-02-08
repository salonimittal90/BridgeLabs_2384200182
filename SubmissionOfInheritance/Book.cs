using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfInheritance
{
    public class Book
    {
        private string Title;
        private int PublicationYear;

        // Constructor
        public Book(string title, int publicationYear)
        {
            this.Title = title;
            this.PublicationYear = publicationYear;
        }
        //method to display book details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }

    // Subclass (Author)
    public class Author : Book
    {
        private string Name;
        private string Bio;

        // Constructor
        public Author(string title, int publicationYear, string name, string bio)
            : base(title, publicationYear)
        {
            this.Name = name;
            this.Bio = bio;
        }
        // Override method 
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author Name: {Name}");
            Console.WriteLine($"Bio: {Bio}");
        }
    }

}