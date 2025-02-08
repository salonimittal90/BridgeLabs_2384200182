using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfInheritance
{
    public class Order
    {
            int OrderId;
            DateTime OrderDate;

            // Constructor
            public Order(int orderId, DateTime orderDate)
            {
                this.OrderId = orderId;
                this.OrderDate = orderDate;
            }

            // Virtual Method to get order status
            public virtual string GetOrderStatus()
            {
                return "Order placed.";
            }

            // Method to display order details
            public virtual void DisplayOrderDetails()
            {
                Console.WriteLine($"Order ID: {OrderId}");
                Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
                Console.WriteLine($"Order Status: {GetOrderStatus()}");
            }
        }
        // Subclass (ShippedOrder)
        public class ShippedOrder : Order
        {
            protected string TrackingNumber;

            // Constructor
            public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
                : base(orderId, orderDate)
            {
                this.TrackingNumber = trackingNumber;
            }

            // Overriding method to update order status
            public override string GetOrderStatus()
            {
                return "Order shipped.";
            }

            // Overriding method 
            public override void DisplayOrderDetails()
            {
                base.DisplayOrderDetails();
                Console.WriteLine($"Tracking Number: {TrackingNumber}");
            }
        }
        // Subclass (DeliveredOrder)
        public class DeliveredOrder : ShippedOrder
        {
            protected DateTime DeliveryDate;

            // Constructor
            public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
                : base(orderId, orderDate, trackingNumber)
            {
                this.DeliveryDate = deliveryDate;
            }

            // Overriding method to update order status
            public override string GetOrderStatus()
            {
                return "Order delivered.";
            }

            // Overriding method 
            public override void DisplayOrderDetails()
            {
                base.DisplayOrderDetails();
                Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
            }
        }

}
