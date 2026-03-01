using System; // Allows us to use Console and other system functions

// Define an interface named IQuittable
// An interface is a contract that any class implementing it must follow
interface IQuittable
{
    // Define a void method named Quit
    // Any class implementing this interface MUST implement this method
    void Quit();
}

// Define a class named Employee
// The colon (:) means Employee is implementing the IQuittable interface
class Employee : IQuittable
{
    // Create some example properties for the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }

    // Implement the Quit() method required by the IQuittable interface
    // Since the interface defines it, we must provide the method body here
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
    }
}

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee emp = new Employee();

        // Assign values to the Employee properties
        emp.FirstName = "John";
        emp.LastName = "Doe";
        emp.Id = 1;

        // Use polymorphism:
        // Create an object of type IQuittable
        // Even though the object is stored as IQuittable,
        // it is actually an Employee object underneath
        IQuittable quittableEmployee = emp;

        // Call the Quit() method using the interface type
        quittableEmployee.Quit();

        // Pause the console so it does not close immediately
        Console.ReadLine();
    }
}
