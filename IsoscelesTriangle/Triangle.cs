/*
Write a program that prints an isosceles triangle of 9 copyright symbols  © 
 */

using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char symbol = '\u00A9';

        Console.WriteLine("   {0}   ", symbol);
        Console.WriteLine();
        Console.WriteLine("  {0} {0}  ", symbol);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0} ", symbol);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}", symbol);

    }
}