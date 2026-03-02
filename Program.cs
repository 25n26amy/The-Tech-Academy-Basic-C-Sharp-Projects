// Include our namespace
using EmployeeComparisonApp;

// Create a namespace for our program
namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object
            Employee employee1 = new Employee();

            // Assign values to employee1 properties
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Create second Employee object
            Employee employee2 = new Employee();

            // Assign values to employee2 properties
            employee2.Id = 1;  // Same Id to test equality
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";

            // Compare employees using overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display result of ==
            Console.WriteLine("Using == operator:");
            Console.WriteLine("Are employees equal? " + areEqual);

            // Compare employees using overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display result of !=
            Console.WriteLine("Using != operator:");
            Console.WriteLine("Are employees NOT equal? " + areNotEqual);

            // Pause so console stays open
            Console.ReadLine();
        }
    }
}