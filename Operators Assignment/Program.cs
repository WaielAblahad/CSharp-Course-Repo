using System;

namespace EmployeeComparisonApp
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Property for employee ID
        public int Id { get; set; }

        // Property for employee first name
        public string FirstName { get; set; }

        // Property for employee last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either is null, but not both, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Return true if their Ids are equal
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator as the inverse of "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match operator ==
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign values
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.FirstName = "Waiel";
            emp1.LastName = "Ablahad";

            // Create second Employee object and assign values
            Employee emp2 = new Employee();
            emp2.Id = 101; // Same Id as emp1 to test equality
            emp2.FirstName = "Ahmed";
            emp2.LastName = "Ablahad";

            // Compare the two Employee objects using overloaded ==
            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employees are NOT equal (different Ids).");
            }

            // Compare the two Employee objects using overloaded !=
            if (emp1 != emp2)
            {
                Console.WriteLine("Employees are different (Ids are not the same).");
            }
            else
            {
                Console.WriteLine("Employees are the same (Ids match).");
            }

            // Wait for user input before closing console
            Console.ReadLine();
        }
    }
}
