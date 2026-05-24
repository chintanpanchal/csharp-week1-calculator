using static System.Console;
namespace Week1Calculator
{
    internal class DayFour
    {
        public static void ExcerciseOne()
        {
            for (int i = 1; i <= 100; i++)
                WriteLine(i);
        }
        public static void ExcerciseTwo()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    WriteLine(i);
            }
        }
        public static void ExcerciseThree()
        {
            WriteLine("Enter a number: ");
            var isValidNumber = int.TryParse(ReadLine(), out int userInput);
            if (isValidNumber)
            {
                for (int i = 1; i <= 10; i++)
                    WriteLine($"{userInput} X {i} = {userInput * i}");
            }
            else
                WriteLine("Please enter the valid number!");
        }
        //*
        //**
        //***
        //****
        //*****
        public static void ExcerciseFour()
        {
            WriteLine("Enter a number: ");
            var isValidNumber = int.TryParse(ReadLine(), out int userInput);
            if (isValidNumber)
            {
                for (int i = 1; i <= userInput; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Write("*");
                    }
                    WriteLine();
                }
            }
        }
    }
}