using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{

    // Node representing a book in the library
    class BookNode
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public BookNode Prev;
        public BookNode Next;

        public BookNode(int id, string title, string author, string genre, bool isAvailable)
        {
            BookID = id;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
            Prev = null;
            Next = null;
        }
    }

    class LibraryManagementSystem
    {
        private BookNode head = null;
        private BookNode tail = null;

        // Add a new book at the beginning
        public void AddAtBeginning(int id, string title, string author, string genre, bool isAvailable)
        {
            BookNode newNode = new BookNode(id, title, author, genre, isAvailable);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        // Add a new book at the end
        public void AddAtEnd(int id, string title, string author, string genre, bool isAvailable)
        {
            BookNode newNode = new BookNode(id, title, author, genre, isAvailable);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        // Remove a book by Book ID
        public void RemoveBook(int id)
        {
            BookNode temp = head;
            while (temp != null && temp.BookID != id)
            {
                temp = temp.Next;
            }
            if (temp == null) return;

            if (temp == head) head = head.Next;
            if (temp == tail) tail = tail.Prev;
            if (temp.Prev != null) temp.Prev.Next = temp.Next;
            if (temp.Next != null) temp.Next.Prev = temp.Prev;
        }

        // Search for a book by Title or Author
        public void SearchBook(string query)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.Title.Equals(query, StringComparison.OrdinalIgnoreCase) || temp.Author.Equals(query, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found Book: ID={temp.BookID}, Title={temp.Title}, Author={temp.Author}, Genre={temp.Genre}, Available={temp.IsAvailable}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found.");
        }

        // Update a book's Availability Status
        public void UpdateAvailability(int id, bool isAvailable)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.BookID == id)
                {
                    temp.IsAvailable = isAvailable;
                    return;
                }
                temp = temp.Next;
            }
        }

        // Display all books in forward order
        public void DisplayBooksForward()
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID={temp.BookID}, Title={temp.Title}, Author={temp.Author}, Genre={temp.Genre}, Available={temp.IsAvailable}");
                temp = temp.Next;
            }
        }

        // Display all books in reverse order
        public void DisplayBooksReverse()
        {
            BookNode temp = tail;
            while (temp != null)
            {
                Console.WriteLine($"ID={temp.BookID}, Title={temp.Title}, Author={temp.Author}, Genre={temp.Genre}, Available={temp.IsAvailable}");
                temp = temp.Prev;
            }
        }

        // Count the total number of books in the library
        public int CountBooks()
        {
            int count = 0;
            BookNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
    }


}
