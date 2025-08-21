using System;

class Program
{
    static void Main()
    {
        // Initial greeting to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for the package's weight
        Console.Write("Enter package weight (in lbs): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // If the package is too heavy, exit early with a message
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Request the dimensions from the user
        Console.Write("Enter package width (in inches): ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter package height (in inches): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter package length (in inches): ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the sum of dimensions exceeds the allowed limit
        double dimensionSum = width + height + length;

        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Perform the shipping quote calculation
        double dimensionalVolume = width * height * length;
        double shippingCost = (dimensionalVolume * weight) / 100.0;

        // Show the user their estimated shipping cost formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:0.00}");
        Console.WriteLine("Thank you for using Package Express!");
    }
}
