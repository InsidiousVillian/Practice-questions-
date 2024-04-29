using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Do_while_with_Sentinel_for_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations of variables
                int studentScores;
                int SIZE = 3;
                int DIVISOR = 3;
                int average;
                string choice;
                string QUIT = "XXX";
                int total = 0;

            //Open the program
            Console.WriteLine("Welcome to the student average program");

            //Prompt user to choose to enter the program or not 
            Console.WriteLine("Do you wish to input a set of Scores, if no type XXX: ");
            choice = Console.ReadLine();

            //Prompt the user to enter values
            if (choice != QUIT)
            {
                do
                {
                    for (int index = 0; index < SIZE; index++)
                    {
                        Console.WriteLine("\nPlease enter the student's score:");
                        studentScores = Convert.ToInt32(Console.ReadLine());

                        //Calculate the total of all scores
                        total = studentScores + total;
                    }

                    //Calculate the average
                    average = total / DIVISOR;

                    //Display the average of the class
                    Console.WriteLine("\nThe average of the class is:" + average);

                    //Set a Priming input to iterate the loop
                    Console.WriteLine("\nDo you wish enter another set of Scores, type XXX to quit: ");
                    choice = Console.ReadLine();

                } while (choice != "XXX");
            }
            else
            {
                //Display an Quit message
                Console.WriteLine("Thank you for your answer, Goodbye.");
            }
        } 
    }
}
