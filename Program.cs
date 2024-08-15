using System;

namespace AutomobileNamespace
{
    // Define the IAutomobile interface
    public interface IAutomobile
    {
        // Define a double property called Speed with an automatic getter
        double Speed { get; }

        // Define an int property called Wheels with an automatic getter
        int Wheels { get; }

        // Define a string property called LicensePlate with an automatic getter
        string LicensePlate { get; }

        // Define a void method called Stringify
        void Stringify();
    }

    // Create a class called Sedan that implements the IAutomobile interface
    public class Sedan : IAutomobile
    {
        // Implement the Speed property with a private setter
        public double Speed { get; private set; }

        // Implement the Wheels property with an automatic getter
        public int Wheels { get; private set; }

        // Implement the LicensePlate property with an automatic getter
        public string LicensePlate { get; private set; }

        // Constructor that takes a double parameter called speed
        public Sedan(double speed)
        {
            Wheels = 4;  // Set Wheels to 4
            Speed = speed;  // Set Speed to the speed parameter
            LicensePlate = "GCTC-06";  // Set LicensePlate to a string
        }

        // Public void method Stringify
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
        }

        // Method to increase the speed of the Sedan by 5
        public void SpeedUp()
        {
            Speed += 5;
        }

        // Method to decrease the speed of the Sedan by 5
        public void SlowDown()
        {
            Speed -= 5;
        }
    }

    // Create a class called Truck that implements the IAutomobile interface
    public class Truck : IAutomobile
    {
        // Implement the Speed property with a private setter
        public double Speed { get; private set; }

        // Implement the Wheels property with an automatic getter
        public int Wheels { get; private set; }

        // Implement the LicensePlate property with an automatic getter
        public string LicensePlate { get; private set; }

        // Define an additional double property called Weight with an automatic getter
        public double Weight { get; private set; }

        // Constructor that takes three parameters
        public Truck(double speed, double weight, string licenseNum)
        {
            Speed = speed;  // Set Speed to the speed parameter
            Weight = weight;  // Set Weight to the weight parameter
            LicensePlate = licenseNum;  // Set LicensePlate to the licenseNum parameter

            // Set Wheels based on the weight parameter
            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        // Public void method Stringify
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
        }

        // Method to increase the speed of the Truck by 5
        public void SpeedUp()
        {
            Speed += 5;
        }

        // Method to decrease the speed of the Truck by 5
        public void SlowDown()
        {
            Speed -= 5;
        }
    }

    // Program class to test the implementations
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Sedan object
            Sedan sedan1 = new Sedan(60);

            // Declare an IAutomobile object and assign it to the sedan object you created
            IAutomobile auto1 = sedan1;

            // Create another new Sedan object with the same speed as the first sedan object
            Sedan sedan2 = new Sedan(60);

            // Call SpeedUp on the first sedan object you created
            sedan1.SpeedUp();

            // Print the Speed of the sedan and the IAutomobile object
            Console.WriteLine($"Speed of sedan1: {sedan1.Speed}");
            Console.WriteLine($"Speed of auto1: {auto1.Speed}");

            // Compare the two objects together (IAutomobile and first Sedan) and print the result to console
            Console.WriteLine($"Are sedan1 and auto1 the same reference? {ReferenceEquals(sedan1, auto1)}");

            // Call SpeedUp on the second sedan object you created
            sedan2.SpeedUp();

            // Now compare both the sedan objects and print the result to console
            Console.WriteLine($"Are sedan1 and sedan2 the same reference? {ReferenceEquals(sedan1, sedan2)}");

            // Create a Truck object
            Truck truck = new Truck(50, 500, "TRK-123");

            // Create an IAutomobile array and add all objects to it
            IAutomobile[] automobiles = new IAutomobile[] { sedan1, auto1, sedan2, truck };

            // Call the Stringify method on all of the objects using a foreach loop
            foreach (var automobile in automobiles)
            {
                automobile.Stringify();
            }
        }
    }
}
