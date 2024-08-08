using System;
using System.Runtime.InteropServices;

namespace NumberAnalyzerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool isWithinRange = userInput >= 1 && userInput <= 100;

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.Clear();

            while (true)
            {
                while (isWithinRange == false)
                {
                    Console.Clear();

                    Console.Write($"{userName}, please enter a number between 1 and 100: ");
                    bool isParsable = int.TryParse(Console.ReadLine(), out userInput);
                    if (!isParsable) continue;

                    Console.Clear();

                    Console.WriteLine($"{userName}, you have entered {userInput}");

                    if (userInput >= 1 && userInput <= 100) isWithinRange = true;
                }

                if (userInput % 2 != 0 && userInput < 60) Console.WriteLine($"{userName}, that number is odd and less than 60.");
                if ((userInput % 2 == 0) && (userInput >= 2 && userInput <= 24)) Console.WriteLine($"{userName}, that number is even and less than 25.");
                if ((userInput % 2 == 0) && (userInput >= 26 && userInput <= 60)) Console.WriteLine($"{userName}, that number is even and between 26 and 60 inclusive.");
                if (userInput % 2 == 0 && userInput > 60) Console.WriteLine($"{userName}, that number is even and greater than 60.");

                Console.WriteLine();
                Console.WriteLine("Do you want to stop the program y/n: ");
                string userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "y" && !string.IsNullOrWhiteSpace(userChoice)) break;
                if (userChoice.ToLower() == "n" && !string.IsNullOrWhiteSpace(userChoice))
                {
                    userInput = 0;
                    isWithinRange = false;
                } 
                Console.Clear();
            }
        }
    }
}
