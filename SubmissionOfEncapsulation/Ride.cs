using System;
using System.Collections.Generic;

// Interface for GPS Tracking
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Abstract Class for Rides
abstract class Ride : IGPS
{
    private int rideId;
    private string driverName;
    private double ratePerKm;
    private string currentLocation;

    // Constructor
    public Ride(int id, string driver, double rate, string location)
    {
        this.rideId = id;
        this.driverName = driver;
        this.ratePerKm = rate;
        this.currentLocation = location;
    }

    // Encapsulation - Properties
    public int RideId { get { return rideId; } }
    public string DriverName { get { return driverName; } }
    public double RatePerKm { get { return ratePerKm; } }

    // Abstract Method for Fare Calculation
    public abstract double CalculateFare(double distance);

    // Concrete Method to Get Ride Details
    public void GetRideDetails()
    {
        Console.WriteLine($"Ride ID: {RideId}, Driver: {DriverName}, Rate: {RatePerKm:C}/km, Location: {GetCurrentLocation()}");
    }

    // Interface Methods for GPS Tracking
    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
        Console.WriteLine($"{DriverName}'s ride is now at {newLocation}");
    }
}

// Cab Class
class Cab : Ride
{
    public Cab(int id, string driver, double rate, string location) : base(id, driver, rate, location) { }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;  // Simple per km charge
    }
}

// Scooter Class
class Scooter : Ride
{
    public Scooter(int id, string driver, double rate, string location) : base(id, driver, rate, location) { }

    public override double CalculateFare(double distance)
    {
        return (RatePerKm * distance) - 10;  // ₹10 Discount for Scooters
    }
}

// Auto Class
class Auto : Ride
{
    public Auto(int id, string driver, double rate, string location) : base(id, driver, rate, location) { }

    public override double CalculateFare(double distance)
    {
        return (RatePerKm * distance) + 5;  // ₹5 Extra Charge for Autos
    }
}