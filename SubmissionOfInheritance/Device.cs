using System;

namespace SubmissionOfInheritance
{
        public class Device
        {
            int DeviceId;
            string Status;

            // Constructor
            public Device(int deviceId, string status)
            {
                this.DeviceId = deviceId;
                this.Status = status;
            }
            // Virtual method to display device status
            public virtual void DisplayStatus()
            {
                Console.WriteLine($"Device ID: {DeviceId}");
                Console.WriteLine($"Status: {Status}");
            }
        }
        // Subclass (Thermostat)
        public class Thermostat : Device
        {
            protected double TemperatureSetting;

            // Constructor
            public Thermostat(int deviceId, string status, double temperatureSetting)
                : base(deviceId, status)
            {
                this.TemperatureSetting = temperatureSetting;
            }
            // Override method 
            public override void DisplayStatus()
            {
                base.DisplayStatus();
                Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
            }
        }
 }
