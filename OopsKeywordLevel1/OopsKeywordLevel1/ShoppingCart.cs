using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class ShoppingCart
    {
        private static double Discount = 10.0; // Default discount in percentage

        // Readonly variable to ensure ProductID is immutable
        private readonly int ProductID;
        private string ProductName;
        private double Price;
        private int Quantity;

        // Constructor using 'this' keyword
        public ShoppingCart(int productId, string productName, double price, int quantity)
        {
            this.ProductID = productId;
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }

        // Static method to update discount percentage
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine("Discount updated to: " + Discount + "%");
        }

        // Method to display product details with discount applied, using 'is' operator
        public void DisplayProductDetails()
        {
            if (this is ShoppingCart)
            {
                double finalPrice = Price - (Price * Discount / 100); // Apply discount
                Console.WriteLine("\nProduct Details:");
                Console.WriteLine("Product ID: " + this.ProductID);
                Console.WriteLine("Name: " + this.ProductName);
                Console.WriteLine("Price (before discount): $" + this.Price);
                Console.WriteLine("Price (after discount): $" + finalPrice);
                Console.WriteLine("Quantity: " + this.Quantity);
            }
            else
            {
                Console.WriteLine("Invalid product object.");
            }
        }
    }
}
