using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class LibraryManagement
    {
        private static string LibraryName = "GLA Library";

        private readonly string isbn;
        private string title;
        private string author;


        public LibraryManagement(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Nmae :" + LibraryName);
        }

        public void DisplayBookDetails()
        {
            if (this is LibraryManagement)
            {
                Console.WriteLine("Book Details:");
                Console.WriteLine("Title: " + this.title);
                Console.WriteLine("Author: " + this.author);
                Console.WriteLine("ISBN: " + this.isbn);
            }
            else
            {
                Console.WriteLine("Invalid book object.");
            }
        }
    }
}

