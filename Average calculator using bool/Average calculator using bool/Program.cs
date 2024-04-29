using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Average_calculator_using_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations of variables
            int studentScores;
            int studentMark;
            int studentPercentage;
            int SIZE = 3;
            int DIVISOR = 3;
            int total = 0;
            int average = 0;
            int FINALTOTAL = 100;
            int PERCENTAGE = 100;

            //Open the program
            Console.WriteLine("Welcome to the student Percentage calcultor");

            //Prompt the user to enter values
            for (int index = 0; index < SIZE; index++)
            {
                Console.WriteLine("\nPlease enter the student's score:");
                studentScores = Convert.ToInt32(Console.ReadLine());

                //Calculate the total of all scores
                total = studentScores + total;
            }

            //Calculate the average and display
            average = total / DIVISOR;
            Console.WriteLine("The average of the scores is:" +  average);

            //Prompt for students average
            Console.WriteLine("\nPlease enter the score you wish to see the percentage on:");
            studentMark = Convert.ToInt32(Console.ReadLine());

            //Calculate the students percentage in the overall class
            studentPercentage = (studentMark * FINALTOTAL) / PERCENTAGE;

            //Set a bool so that it tests a condition
            bool passAverage = true;

            //Test if the student opass the class average
            if ((studentPercentage >= 50) == passAverage)
            {
                Console.WriteLine("\nCongradulations, you have an percentage of: " + studentPercentage + "%");
            }
            else
            {
                Console.WriteLine("\nSorry, you did not reach the average of the class: " + studentPercentage + "%");
            }
        }
    }
}
