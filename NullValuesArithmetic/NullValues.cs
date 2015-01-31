/*
• Create a program that assigns null values to an integer and to a double variable. 
• Try to print these variables at the console. 
• Try to add some number or the null literal to these variables and print the result.
*/

using System;

class NullValues
{
    static void Main()
    {
        int? iVar = null;
        double? dVar =null;

        // Print initial values of the two variables
        Console.WriteLine(iVar);
        Console.WriteLine(dVar);

        //Add some numbers to the variables
        iVar = -15;
        dVar = 2437473465544552345;

        // Print assigned values of the two variables
        Console.WriteLine(iVar);
        Console.WriteLine(dVar);

    }
}