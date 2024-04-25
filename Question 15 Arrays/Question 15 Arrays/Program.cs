using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Question_15_Arrays
{
    internal class Program
    {
        //Globally declare variables
        static int[] userNumbers;
        static int total = 0;
        static int average;
        static void Main(string[] args)
        {
            //Declarations of variables
            int[] userNumbers;
            int finalAverage;
            int SIZE = 6;
            string choice;

            //Set an array to hold values
            userNumbers = new int[SIZE];

            //Start the program by asking user if they want to create a set of numbers
            Console.WriteLine("Welcome to the Arithemtic set Program");
            Console.WriteLine("\nDo you wish to enter a set of 6 numbers: YES or NO");
            choice = Console.ReadLine();

            //Check the user's choice
            while (choice == "YES")
                {
                //Prompt user to enter values for the array
                for (int index = 0; index < SIZE - 1; index++)
                {
                    Console.WriteLine("\nPlease enter your number:");
                    userNumbers[index] = Convert.ToInt32(Console.ReadLine());
                }
                //Call a method to calculate the average of the values
                finalAverage = CalculateArithmetic(userNumbers);

                //Set a space between the input and comparison for readability
                Console.WriteLine("\n");

                //Display the values and show how far it is from the Average
                displayValues(finalAverage,userNumbers);

                //Reprompt user to enter another set or close program
                Console.WriteLine("\nDo you wish to enter another set of 6 numbers: YES or NO");
                choice = Console.ReadLine();
            }
            //Display an exit message
            if (choice == "NO")
            {
                Console.WriteLine("Thank you for your answer. Goodbye.");
                return;
            }
        }
        //Create a method to calculate the average
        static int CalculateArithmetic(int[] userNumbers)
        {
            //Declarations of variables
            int total = 0;
            int SIZE = 6;

            //Calculate total of input and average
            for (int i = 0; i < SIZE - 1; i++)
            {
                total += userNumbers[i];
            }
            average = total / SIZE;
            return average;
        }
        //Create a method to display how far the values are to the average
        static void displayValues(int finalAverage, int[] userNumbers)
        {
            //Declarations
            int SIZE = 6;
            int valuesDistance = 0;

            //Display the distance of the values to the average
            for (int counter = 0; counter < SIZE - 1; counter++)
            {
                valuesDistance = finalAverage - userNumbers[counter];
                Console.WriteLine(userNumbers[counter] + " is " + valuesDistance + " units away from the Average of your set of numbers.");
            }
        }
    }
}
