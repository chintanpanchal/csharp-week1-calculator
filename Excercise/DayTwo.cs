using System;
namespace Week1Calculator
{
    internal class DayTwo
    {
        public static void GreetUser()
        {
            Console.WriteLine("Please enter your name:");
            string? userInput = Console.ReadLine();
            string Message = string.Empty;
            if(string.IsNullOrWhiteSpace(userInput))
                Message = "please enter the name.";
            Message = $"Hello {userInput}, Welcome to c#";
            Console.WriteLine(Message);
        }
    }
}