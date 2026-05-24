using static System.Console;
namespace Week1Calculator
{
    internal class DayThree
    {
        public static void GradeCalculator()
        {
            WriteLine("Please enter the score: ");
            string grade = string.Empty;
            var isValidNumber = int.TryParse(ReadLine(), out int userInput);
            if (!isValidNumber)
                WriteLine("Please enter a valid score");
            else
            {
                if (userInput >= 90 && userInput <= 100)
                    grade = "A";
                else if (userInput >= 80 && userInput <= 89)
                    grade = "B";
                else if (userInput >= 70 && userInput <= 79)
                    grade = "C";
                else if (userInput >= 60 && userInput <= 69)
                    grade = "D";
                else if (userInput >= 0 && userInput <= 59)
                    grade = "F";
                else
                    grade = "Invalid score";
                WriteLine($"Grade: {grade}");
            }
        }
        public static void GradeCalculatorSwitch()
        {
            WriteLine("Please enter the score: ");
            string grade = string.Empty;
            var isValidNumber = int.TryParse(ReadLine(), out int userInput);
            if (!isValidNumber)
                WriteLine("Please enter a valid score");
            else
            {
                switch (userInput / 10)
                {
                    case 10:
                    case 9:
                        grade = "A";
                        break;
                    case 8:
                        grade = "B";
                        break;
                    case 7:
                        grade = "C";
                        break;
                    case 6:
                        grade = "D";
                        break;
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        grade = "F";
                        break;
                    default:
                        grade = "Invalid score";
                        break;
                }
                WriteLine($"Grade: {grade}");
            }
        }
    }
}