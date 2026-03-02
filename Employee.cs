// Define a namespace to organize our classes
namespace EmployeeComparisonApp
{
    // Create the Employee class
    public class Employee
    {
        // Property to store the employee's ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the == operator
        // This allows us to compare two Employee objects using ==
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null and the other is not, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Id properties of both employees
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator
        // Required when overloading ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of ==
            return !(emp1 == emp2);
        }

        // Override Equals method (good practice when overloading ==)
        public override bool Equals(object obj)
        {
            // Check if object is an Employee
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }

            return false;
        }

        // Override GetHashCode (required when overriding Equals)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}