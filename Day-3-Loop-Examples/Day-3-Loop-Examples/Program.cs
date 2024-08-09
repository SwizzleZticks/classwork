using System;

namespace Day_3_Loop_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberSum = 0;
            double userInput = 0;
            int numNums = 5; //use this to make things loosely coupled

            //Ask the user how many numbers they have
            Console.WriteLine("How many numbers do you have to enter: ");
            numNums = int.Parse(Console.ReadLine());

            for (int i = 0; i < numNums; i++) 
            {
                //Ask the user for a number
                Console.WriteLine("Please enter number " + (i + 1) + " of " + numNums);
                userInput = int.Parse(Console.ReadLine());
                //Add the numbers up
                numberSum = numberSum + userInput;
            }

            //Find the average of the numbers
            double numberAverage = (double)numberSum / numNums;
            //double numberAverage = (double)numberSum / 3.0; <- other than casting it you can make the literal a double

            //Display the sum and avaerage
            Console.WriteLine("The sum is: " + numberSum);
            Console.WriteLine("The average is: " + numberAverage);

            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
