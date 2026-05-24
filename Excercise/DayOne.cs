using System;

namespace Week1Calculator
{
    internal class DayOne
    {
        public static void PracticeVariable()
        {
            string name = "Chintan PANCHAL";
            int age = 25;
            double height = 1.75D;
            float weight = 70.59F;
            bool isLearningCSharp = true;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(isLearningCSharp);
        }

        public static void PracticeDataTypes()
        {
            Console.WriteLine("My name is John");
            Console.WriteLine("I am learning C#");
            Console.WriteLine(10 + 5);
            Console.WriteLine(10 * 3);
            Console.WriteLine(100 / 4);
            Console.WriteLine("The result of 7 * 8 is: " + (7 * 8));
        }
    }
}