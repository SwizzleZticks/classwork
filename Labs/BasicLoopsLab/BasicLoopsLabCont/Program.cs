using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopsLabCont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doorLocked = true;
            int doorCode = 13579;
            int guessCount = 5;

            do
            {
                Console.Write("Enter the door code to unlock the door: ");
                bool isParsible = int.TryParse(Console.ReadLine(), out int userGuess);

                if (isParsible)
                {
                    if ((userGuess == doorCode) && (guessCount > 0))
                    {
                        Console.WriteLine("Welcome to my house!");
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
            } while (doorLocked);
            Console.ReadLine();
        }
    }
}
