﻿namespace Lab_Sheet_01____Qusetion_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ente the radius: ");
            double radius = Convert.ToInt32(Console.ReadLine());
            double Area = Math.PI*radius*radius;
            Console.Write("The area of circle :" + Area);
            
            
            
        }
    }
}