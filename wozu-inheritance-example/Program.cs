using System;

namespace lesson7
{
    // Vehicle Class
    public class Vehicle
    {
        string make;
        string color;
        bool isRunning = false;
        int fuelLevel;

        public Vehicle(string make, string color, int fuelLevel)
        {
            this.make = make;
            this.color = color;
            this.isRunning = false;
            this.fuelLevel = fuelLevel;
        }
        public void printDetails()
        {
            Console.WriteLine("The " + this.color + " " + this.make + " has a fuel level of " + this.fuelLevel + ". Is it running? " + this.isRunning);
        }
    }

    // Car Class
    public class Car : Vehicle
    {
        int trunkWidth;

        public Car(string make, string color, int fuelLevel, int trunkWidth)
            : base(make, color, fuelLevel)
        {
            this.trunkWidth = trunkWidth;
        }
    }

    // Truck Class
    public class Truck : Vehicle
    {
        int flatbedLength;

        public Truck(string make, string color, int fuelLevel, int flatbedLength)
            : base(make, color, fuelLevel)
        {
            this.flatbedLength = flatbedLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newVehicle = new Vehicle("AcmeVehicle", "Gray", 5);
            newVehicle.printDetails();

            Car newCar = new Car("AcmeCar", "Black", 15, 10);
            newCar.printDetails();

            Truck newTruck = new Truck("AcmeTruck", "White", 25, 20);
            newTruck.printDetails();
        }
    }
}