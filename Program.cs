using System; // Allows us to use basic system functions like Console

// Define a custom class called MathOperations
class MathOperations
{
    // This method takes two integers as parameters
    // It performs a math operation on the first integer
    // Then it displays the second integer to the screen
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (multiply by 2)
        int result = firstNumber * 2;

        // Display the result of the math operation
        Console.WriteLine("The result of the math operation on the first number is: " + result);

        // Display the second integer to the screen
        Console.WriteLine("The second number is: " + secondNumber);
    }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Instantiate (create an object of) the MathOperations class
        MathOperations mathObject = new MathOperations();

        // Call the method by passing two numbers normally
        mathObject.DoMath(5, 10);

        // Call the method again, specifying the parameters by name
        mathObject.DoMath(firstNumber: 7, secondNumber: 20);

        // Keep the console window open until user presses a key
        Console.ReadLine();
    }
}
