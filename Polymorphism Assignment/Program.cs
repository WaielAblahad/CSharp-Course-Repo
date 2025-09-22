using System;

namespace InterfaceExampleApp
{
    // Define an interface named IQuittable
    public interface IQuittable
    {
        // Declare a method named Quit with no return value
        void Quit();
    }

    // Employee class inherits from IQuittable interface
    public class Employee : IQuittable
    {
        // Property for employee ID
        public int Id { get; set; }

        // Property for employee first name
        public string FirstName { get; set; }

        // Property for employee last name
        public string LastName { get; set; }

        // Implement the Quit method from IQuittable interface
        public void Quit()
        {
            // Print a simple message when Quit is called
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and assign values to its properties
            Employee emp = new Employee();
            emp.Id = 202;
            emp.FirstName = "Waiel";
            emp.LastName = "Ablahad";

            // Use polymorphism to assign the Employee object to a variable of type IQuittable
            IQuittable quittableEmployee = emp;

            // Call the Quit method using the IQuittable interface reference
            quittableEmployee.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
