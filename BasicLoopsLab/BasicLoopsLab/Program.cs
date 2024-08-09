using System;

namespace BasicLoopsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            do
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue (y/n)?");
                userInput = Console.ReadLine();
            } while (userInput.ToLower() != "n" && !string.IsNullOrEmpty(userInput));

            Console.Clear();

            //**************************************************************

            do
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Clear();

                for (int i = number; i >= 0; i--)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();

                for (int i = 0; i <= number; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();

                Console.WriteLine("Would you like to continue (y/n)?");
                userInput = Console.ReadLine();
                Console.Clear();
            } while (userInput.ToLower() != "n" && !string.IsNullOrEmpty(userInput));

            //****************************************************************

            bool doorLocked = true;
            int doorCode = 13579;
            int guessCount = 5;

            while (doorLocked) 
            {
                Console.Write("Enter the door code to unlock the door: ");
                bool isParsible = int.TryParse(Console.ReadLine(), out int userGuess);

                if (isParsible)
                {

                    if ((userGuess == doorCode) && (guessCount > 0))
                    {
                        Console.WriteLine("Welcome to my house");
                        doorLocked = false;
                    }
                    else if ((userGuess != doorCode) && (guessCount > 0))
                    {
                        Console.Clear();
                        Console.WriteLine("That password was incorrect please try again.");
                        guessCount--;
                    }
                    else if (guessCount == 0)
                    {
                        Console.WriteLine("Too many incorrect attempts!");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
