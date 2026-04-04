using System;

namespace MethodAssignment
{
    // This class contains math methods
    public class MathOperations
    {
        // Void method that takes 2 integers
        public void DoMath(int number1, int number2)
        {
            // Multiply first number by 2
            int result = number1 * 2;

            // Display result
            Console.WriteLine("Result of first number * 2: " + result);

            // Display second number
            Console.WriteLine("Second number is: " + number2);
        }
    }
}