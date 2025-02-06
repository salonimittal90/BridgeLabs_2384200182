using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsObjectModeling
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }

        // Display product details
        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {ProductName}, Price: ${Price}");
        }
    }

    // Order class (Aggregation: Order has multiple Products)
    class Order
    {
        public string OrderId { get; set; }
        public List<Product> Products { get; set; }
        public double TotalAmount { get; private set; }

        public Order(string orderId)
        {
            OrderId = orderId;
            Products = new List<Product>();  // Initializing the list
            TotalAmount = 0;
        }

        // Add product to the order
        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalAmount += product.Price;
            Console.WriteLine($"Product {product.ProductName} added to Order {OrderId}");
        }

        // Display order details
        public void DisplayOrder()
        {
            Console.WriteLine($"\nOrder ID: {OrderId}");
            Console.WriteLine("Products in this order:");
            foreach (var product in Products)
            {
                product.DisplayProduct();
            }
            Console.WriteLine($"Total Amount: ${TotalAmount}");
        }
    }

    // Customer class (Aggregation: Customer has multiple Orders)
    class EcommerceCustomer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public EcommerceCustomer(string name, string email)
        {
            CustomerName = name;
            Email = email;
            Orders = new List<Order>();  // Initializing the list
        }

        // Customer places an order
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine($"{CustomerName} placed an order with Order ID: {order.OrderId}");
        }

        // Display all orders of the customer
        public void DisplayCustomerOrders()
        {
            Console.WriteLine($"\nCustomer: {CustomerName}, Email: {Email}");
            if (Orders.Count > 0)
            {
                foreach (var order in Orders)
                {
                    order.DisplayOrder();
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No orders placed yet.");
            }
        }
    }
}
