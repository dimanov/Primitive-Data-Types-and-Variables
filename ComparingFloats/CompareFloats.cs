/*
Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 .
*/

using System;

class CompareFloats
{
    static void Main()
    {
        double f1;
        double f2;
        double eps = 0.000001;

        Console.WriteLine("This program compares two floating-point numbers with precision of 0.000001");
        Console.WriteLine("Please enter the first floating-point number:");
        f1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the second floating-point number:");
        f2 = Convert.ToDouble(Console.ReadLine());

        bool comparison = Math.Abs(f1 - f2) <= eps;

        if (comparison)
        {
            Console.WriteLine("The two numbers are equal within the defined precision");
        }
        else
        {
            Console.WriteLine("The two numbers are NOT equal within the defined precision");
        }
    }
}