using System;

namespace area_of_a_triangle
{
    internal class Program
    {
        static double area; 
        static void Main(string[] args)
        {
            //Declarations 
            double Height;
            double Base;

            Console.WriteLine("what is the height of the triangle");
            Height = int.Parse(Console.ReadLine());

            Console.WriteLine("what is the base of the triangle");
            Base = int.Parse(Console.ReadLine());

            // call method 
            CalculateArea(Height, Base);

        }
        static void CalculateArea(double Height, double Base)
        {
           
             double area = 0.5 * (Height * Base);


            Console.WriteLine("the area of the triangle is:" + area);
            Console.ReadLine();

            return ;
         
        }
       
    }
}
