using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsObjectModeling
{
    //create a book class and it is independent
    public class Book
    {
        //define Attributes
        public string Author;
        public string Title;

        //constructor used to initialize the value of attributes
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;

        }

        //method to display the author name and title
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }


    }

    //create another class Library
    public class Library
    {
        public string Name;
        //attribute which define the name of library

        //create list to store the books
        public List<Book> Books;

        //constructor which initialize the empty list
        public Library(string name)
        {
            this.Name = name;
            Books = new List<Book>(); // initialize an empty list
        }


        //method to add book
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the {Name} Library");
        }

        //method that display books in the library
        public void DisplayLibrary()
        {
            Console.WriteLine($"\n Library : {Name}");
            foreach (Book book in Books)
            {
                book.DisplayInfo();
            }

        }
    }
}
