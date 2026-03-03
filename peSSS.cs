// See https://aka.ms/new-console-template for more information
using System;

// Display welcome message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask for package weight
Console.WriteLine("Please enter the package weight:");
decimal weight = Convert.ToDecimal(Console.ReadLine());

// If weight is greater than 50, stop program
if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Ask for width
Console.WriteLine("Please enter the package width:");
decimal width = Convert.ToDecimal(Console.ReadLine());

// Ask for height
Console.WriteLine("Please enter the package height:");
decimal height = Convert.ToDecimal(Console.ReadLine());

// Ask for length
Console.WriteLine("Please enter the package length:");
decimal length = Convert.ToDecimal(Console.ReadLine());

// Check if dimensions exceed 50
if ((width + height + length) > 50)
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return;
}

// Calculate quote
decimal quote = (width * height * length * weight) / 100;

// Display formatted result
Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

Console.WriteLine("Thank you!");
