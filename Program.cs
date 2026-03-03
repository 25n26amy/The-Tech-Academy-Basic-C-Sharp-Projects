using System; // Allows us to use Console and basic system functions

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message as required
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // If weight is greater than 50, display error and end program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program immediately
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if total dimensions exceed 50
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program
        }

        // Multiply dimensions together
        decimal volume = width * height * length;

        // Multiply volume by weight and divide by 100
        decimal quote = (volume * weight) / 100;

        // Display quote formatted as currency with 2 decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

        // Thank the user
        Console.WriteLine("Thank you!");

        // Keep console window open
        Console.ReadLine();
    }
}