using System;
namespace SubmissionOfEncapsulation
{
    // Interface for Discount System
    interface IDiscountable
    {
        void ApplyDiscount(double discountPercentage);
        string GetDiscountDetails();
    }

    // Abstract Class for Food Items
    abstract class FoodItem : IDiscountable
    {
        private string itemName;
        private double price;
        private int quantity;
        private double discountApplied = 0;

        // Constructor
        public FoodItem(string name, double price, int quantity)
        {
            this.itemName = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Encapsulation - Properties
        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }

        // Abstract Method for Total Price Calculation
        public abstract double CalculateTotalPrice();

        // Concrete Method to Get Item Details
        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}, Total Price: {CalculateTotalPrice():C}");
        }

        // Interface Methods for Discount
        public void ApplyDiscount(double discountPercentage)
        {
            discountApplied = (CalculateTotalPrice() * discountPercentage) / 100;
            Console.WriteLine($"{discountPercentage}% discount applied on {ItemName}. Discount Amount: {discountApplied:C}");
        }

        public string GetDiscountDetails()
        {
            return $"Discount on {ItemName}: {discountApplied:C}";
        }
    }

    // Veg Item Class
    class VegItem : FoodItem
    {
        public VegItem(string name, double price, int quantity) : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) - 10;  // ₹10 Discount for Veg Items
        }
    }

    // Non-Veg Item Class
    class NonVegItem : FoodItem
    {
        public NonVegItem(string name, double price, int quantity) : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 20;  // ₹20 Extra Charge for Non-Veg Items
        }
    }

}
