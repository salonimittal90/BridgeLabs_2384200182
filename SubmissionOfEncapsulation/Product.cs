using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfEncapsulation
{
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // Abstract Class for Products
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        // Constructor
        public Product(int id, string prodName, double prodPrice)
        {
            this.productId = id;
            this.name = prodName;
            this.price = prodPrice;
        }

        // Encapsulation - Properties
        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price { get { return price; } set { price = value; } }

        // Abstract Method
        public abstract double CalculateDiscount();

        // Concrete Method to Display Details
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {Name}, Price: {Price:C}");
        }
    }

    // Electronics Class implementing ITaxable
    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.10;  // 10% Discount
        }

        public double CalculateTax()
        {
            return Price * 0.18;  // 18% GST on Electronics
        }

        public string GetTaxDetails()
        {
            return "GST 18% Applied on Electronics";
        }
    }

    // Clothing Class implementing ITaxable
    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.15;  // 15% Discount
        }

        public double CalculateTax()
        {
            return Price * 0.05;  // 5% GST on Clothing
        }

        public string GetTaxDetails()
        {
            return "GST 5% Applied on Clothing";
        }
    }

    // Groceries Class (No Tax)
    class Groceries : Product
    {
        public Groceries(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.05;  // 5% Discount
        }
    }
}