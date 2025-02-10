using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfEncapsulation
{
    // Interface for Reservation System
    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    // Abstract Class for Library Items
    abstract class LibraryItem : IReservable
    {
        private int itemId;
        private string title;
        private string author;
        private bool isAvailable = true;
        private string borrowerName;

        // Constructor
        public LibraryItem(int id, string title, string author)
        {
            this.itemId = id;
            this.title = title;
            this.author = author;
        }

        // Encapsulation - Properties
        public int ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        // Abstract Method for Loan Duration
        public abstract int GetLoanDuration();

        // Concrete Method to Get Item Details
        public void GetItemDetails()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}, Loan Duration: {GetLoanDuration()} days");
        }

        // Encapsulated Borrower Data
        public void BorrowItem(string borrower)
        {
            if (isAvailable)
            {
                borrowerName = borrower;
                isAvailable = false;
                Console.WriteLine($"{Title} has been borrowed by {borrower}.");
            }
            else
            {
                Console.WriteLine($"{Title} is currently unavailable.");
            }
        }

        // Interface Methods for Reservation
        public void ReserveItem()
        {
            Console.WriteLine($"{Title} has been reserved.");
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    // Book Class
    class Book : LibraryItem
    {
        public Book(int id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 14;  // 14 days for books
        }
    }

    // Magazine Class
    class Magazine : LibraryItem
    {
        public Magazine(int id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 7;  // 7 days for magazines
        }
    }

    // DVD Class
    class DVD : LibraryItem
    {
        public DVD(int id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 3;  // 3 days for DVDs
        }
    }

}
