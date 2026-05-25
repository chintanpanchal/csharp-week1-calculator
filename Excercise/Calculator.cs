using static System.Console;
namespace Week1Calculator
{
    internal class Calculator
    {
        public static void Run()
        {
            string? isValidInput = string.Empty;
            while (true)
            {
                WriteLine("Enter calculation (e.g. 5 + 3) or 'exit' to quit: ");
                isValidInput = ReadLine();
                if (string.IsNullOrWhiteSpace(isValidInput))
                {
                    WriteLine("Please enter a calculation or 'exit'.");
                    continue;
                }
                if (string.Equals(isValidInput, "exit"))
                {
                    WriteLine("Goodbye!");
                    break;
                }
                var exp = isValidInput.Split(' ');
                if (exp.Length == 3)
                {
                    var valueOne = int.TryParse(exp[0], out int expOne);
                    var valueTwo = int.TryParse(exp[2], out int expTwo);
                    var expOperetor = exp[1];
                    var result = 0;
                    var validOperation = true;
                    if (valueOne && valueTwo)
                    {
                        switch (expOperetor)
                        {
                            case "+":
                                result = expOne + expTwo;
                                break;
                            case "-":
                                result = expOne - expTwo;
                                break;
                            case "*":
                                result = expOne * expTwo;
                                break;
                            case "/":
                                if (expTwo == 0)
                                {
                                    validOperation = false;
                                    WriteLine("Error: Cannot divide by zero");
                                }
                                else
                                    result = expOne / expTwo;
                                break;
                            case "%":
                                result = expOne % expTwo;
                                break;
                            default:
                                WriteLine("enter valid operator for calculations");
                                validOperation = false;
                                break;
                        }
                        if (validOperation)
                            WriteLine($"Result: {result}");
                    }
                    else
                        WriteLine("Please enter the valid numbers");
                }
                else
                    WriteLine("Not valid expressions!");
            }
        }
    }
}
