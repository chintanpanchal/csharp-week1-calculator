using static System.Console;
namespace Week1Calculator
{
    internal class DayFive
    {
        public static void FizzBuzz()
        {
            WriteLine("Enter the upper limit:");
            var isValidInput = int.TryParse(ReadLine(), out int userInput);
            if (!isValidInput)
                WriteLine("Enter the valid number!");
            else
            {
                for (int i = 1; i <= userInput; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                        WriteLine("FizzBuzz");
                    else if (i % 3 == 0)
                        WriteLine("Fizz");
                    else if (i % 5 == 0)
                        WriteLine("Buzz");
                    else
                        WriteLine($"{i}");
                }
            }
        }

        public static void GuessingGame()
        {
            Random rnd = new Random();
            var guessedNum = rnd.Next(1, 101);
            var attempts = 0;
            WriteLine("I'm thinking of a number between 1 and 100.");
            while (true)
            {
                Write("Your guess: ");
                var isValidInput = int.TryParse(ReadLine(), out int userInput);
                if (!isValidInput)
                    WriteLine("Please enter a valid number.");
                else
                {
                    attempts++;
                    if (userInput > guessedNum)
                        WriteLine("Too high!");
                    else if (userInput < guessedNum)
                        WriteLine("Too low!");
                    else
                    {
                        WriteLine($"Correct! you got it in {attempts} attempts.");
                        break;
                    }
                }
            }
        }
    }
}