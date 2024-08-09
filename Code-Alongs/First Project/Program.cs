//This is a single line comment
/*
* This is a block comment
*/
//Any code in a comment is ignored

//Program.cs is the main executable file for your application
//It contains the code for the application

//using allows you access to C# code you need for the application
using System;//Give me access to the basic c# system code(basic functionality)

//Code in c# is grouped in namespaces
//
//A namespace identifies a context in which a word or thing is defined or known
//             allow the same name or thing to be used in different contexts
namespace First_Project
{//marks the start of the namespace
    // a class is used to group things that related or used together
    // every application has at least one class containing the primary or startup code for the app
    //an internal class cannot be used outside the context in which defined(more later)
    //{ } are used to indicate a self contained block of code
    internal class Program //Program is the name of the class that contains the application
    {//start of class program
        //Every application contains exactly one method called main
        //a method is a self contained unit of code
        //main is the starting point for execution of the application(entry point)

        //static - indicates there is only one of these
        //void   - indicates a method does not return a value
        //main   - is the name of the method
        //(string[] args) - indicates the data type and name of any parameters for the method
        static void Main(string[] args)
        {// marks the start of the code in main

            // a piece of data in/for a program is called a variable
            // not understanding the data in for a program causes many programming issues

            //variables have data types and names and may hold values that are compatible with the type

            //commonly used data types in c# 
            //
            //int    - whole number between +/- 2 billion
            //long   - a whole number greater than +/- 2 billion
            //double - a number with decimal places
            //char   - a single alpanumeric character
            //string - a multiple alphanumeric character
            //bool   - true or false value

            //define a variable holding the current year (2024)
            int thisYear = 2024;

            //define a variable to hold the value of pi with 2 decimals
            double pi = 3.14;

            //to display a line on the screen: Console.WriteLine("What to display");
            //words or characters are enclosed in ""
            //variable names or numeric values are not enclosed in ""
            //Multiple things can be displayed by separating them with +

            //display the value in this year
            Console.WriteLine($"This year is: { thisYear }");

            //to keep console window open after exection
            //have the program wait for the enter key to close application
            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();
        }//marks the end of the code in main
    }//end class program
}//end of name
