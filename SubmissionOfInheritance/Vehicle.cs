using System;

namespace SubmissionOfInheritance
{
    //  Base Class: Vehicle
    public class Vehicle
    {
        // Attributes of Vehicle class
        public int MaxSpeed;
        public string FuelType;

        // Constructor
        public Vehicle(int maxSpeed, string fuelType)
        {
            this.MaxSpeed = maxSpeed;
            this.FuelType = fuelType;
        }

        // Virtual method to display information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"---Information of {this.GetType().Name}---");
            Console.WriteLine("Maximum Speed : " + MaxSpeed);
            Console.WriteLine("Fuel Type : " + FuelType);
        }
    }

    //Subclass: Car
    public class Car : Vehicle
    {
        int SeatCapacity;
        // Constructor of Car class
        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            this.SeatCapacity = seatCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // ✅ Calling base class method
            Console.WriteLine("Seat Capacity : " + SeatCapacity);
        }
    }

    //Subclass: Truck
    public class Truck : Vehicle
    {
        int PayloadCapacity;
        // Constructor of Truck class
        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            this.PayloadCapacity = payloadCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity : " + PayloadCapacity);
        }
    }

    //Subclass: Motorcycle
    public class Motorcycle : Vehicle
    {
        bool HasSidecar;
        // Constructor of Motorcycle class
        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            this.HasSidecar = hasSidecar;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Motorcycle has a sidecar : " + (HasSidecar ? "Yes" : "No"));
        }
    }
}
