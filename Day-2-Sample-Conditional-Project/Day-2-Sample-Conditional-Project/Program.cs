using System;


namespace Day_2_Sample_Conditional_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for an odd number between 11 and 17
            //Verify they have entered a correct value
            //
            //A number is odd if it is not evenly divisble by 2
            //if we divide it by 2 and the remainder is not 0, its odd
            //
            //c# has modulus which provides the remainder after division

            Console.Write("Please enter an odd number between 11 and 17: ");
            int userInput = int.Parse(Console.ReadLine()); //Get user input and convert it to an int

            //Show the user what we got from them
            Console.WriteLine($"You entered { userInput }");

            //Verify the number is between 11 and 17
            if (userInput >= 11 && userInput <= 17 && userInput % 2 != 0)
            {
                Console.WriteLine("The value is odd and between 11 and 17");
            }
            else
            {
                Console.WriteLine("The value is not odd and between 11 and 17");
            }

            //Make visual studio keep the console window open till we are done
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
