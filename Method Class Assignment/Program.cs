using System;

namespace ConsoleAppExample
{
    // Define a class called MathOperations
    class MathOperations
    {
        // Define a void method that takes two integers as parameters
        public void PerformOperation(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = number1 * 2;

            // Display the result of the operation
            Console.WriteLine("Result of operation on first number (number1 * 2): " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number is: " + number2);
        }
    }

    class Program
    {
        // Main method — the entry point of the console app
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method using positional arguments
            mathOps.PerformOperation(5, 15);

            // Call the PerformOperation method using named arguments
            mathOps.PerformOperation(number1: 3, number2: 15);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
