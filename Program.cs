using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the MathOperations class
            MathOperations mathObject = new MathOperations();

            // Call the method normally with two numbers
            mathObject.DoMath(5, 10);

            // Call the method again using named parameters
            mathObject.DoMath(number1: 7, number2: 20);

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
