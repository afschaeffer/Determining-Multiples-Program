// CIS243 Assignment 1
// 06/01/2020
// Amy Schaeffer
// Program taking user input and determining if one is a multiple of the other.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Schaeffer
{
    class Program
    {
        static void Main()
        {
            // While loop allowing user to loop through the program until finished
            while(true)
            {
                Console.Write("Enter first integer: "); // Prompting user to enter integer
                int int1 = Convert.ToInt32(Console.ReadLine()); // Reading user entry
                Console.Write("Enter second integer: "); //Promting user to enter second integer
                int int2 = Convert.ToInt32(Console.ReadLine()); // Reading user entry

                if (int1 % int2 == 0) // If statement checking if the integers divided return a remainder other than 0
                {
                    Console.WriteLine(int1 + " is a multiple of " + int2); // If the remainder is 0, let the user know second integer is a multiple of the first
                }
                else
                {
                    Console.WriteLine(int1 + " is not a multiple of " + int2); // If the remainder is not 0, let the user know second integer is not a multiple of the first
                }

                Console.Write("Do you wish to try again? Type anything to continue or 'exit' to exit: "); // Asking user if they would like to exit or retry
                string repeat = Console.ReadLine(); // Defining variable 'repeat'
                if (repeat == "exit") 
                    break; // Breaking loop and exiting program if user enters 'exit'

            }
        }
    }
}
