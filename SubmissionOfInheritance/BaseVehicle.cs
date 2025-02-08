using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmissionOfInheritance
{
        public class BaseVehicle
        {
            protected int MaxSpeed;
            protected string Model;

            // Constructor
            public BaseVehicle(int maxSpeed, string model)
            {
                this.MaxSpeed = maxSpeed;
                this.Model = model;
            }

            // Method to display vehicle information
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
            }
        }

        // Interface (Refuelable) - For Petrol Vehicles
        public interface IRefuelable
        {
            void Refuel();
        }

        // Subclass (ElectricVehicle)
        public class ElectricVehicle : BaseVehicle
        {
            public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

            // Unique method for ElectricVehicle
            public void Charge()
            {
                Console.WriteLine($"{Model} is charging at the charging station.");
            }

            // Overriding DisplayInfo
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("This is an Electric Vehicle.");
            }
        }

        // Subclass (PetrolVehicle) - Implements IRefuelable Interface
        public class PetrolVehicle : BaseVehicle, IRefuelable
        {
            public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

            // Implementing Refuel method from interface
            public void Refuel()
            {
                Console.WriteLine($"{Model} is refueling at the petrol station.");
            }

            // Overriding DisplayInfo
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("This is a Petrol Vehicle.");
            }
        }

    }