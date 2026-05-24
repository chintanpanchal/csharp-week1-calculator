using System;
namespace Week1Calculator
{
    internal class DayTwo
    {
        public static void GreetUser()
        {
            Console.WriteLine("Please enter your name:");
            string? userInput = Console.ReadLine();
            string message;
            if (string.IsNullOrWhiteSpace(userInput))
                message = "please enter the name.";
            else
                message = $"Hello {userInput}, Welcome to c#";
            Console.WriteLine(message);
        }
    }
}