/*
 * Which of the following values can be assigned to a variable of type  float  and which to a variable of type  double : 
 * 34.567839023, 12.345, 8923.1234857, 3456.091 ?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

class FloatDouble
{
    static void Main()
    {
        double var1 = 34.567839023;
        float var2 = 12.345F;
        double var3 = 8923.1234857;
        float var4 = 3456.091F;

        Console.WriteLine("The first value {0} is saved in {1} type of variables.", var1, var1.GetType());
        Console.WriteLine("The second value {0} is saved in {1} type of variables.", var2, var2.GetType());
        Console.WriteLine("The third value {0} is saved in {1} type of variables.", var3, var3.GetType());
        Console.WriteLine("The fourth value {0} is saved in {1} type of variables.", var4, var4.GetType());
    }
}