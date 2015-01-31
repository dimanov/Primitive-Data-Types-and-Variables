/*
* Declare an integer variable and assign it with the value  254  in hexadecimal format ( 0x## ).  
* Use Windows Calculator to find its hexadecimal representation.  
* Print the variable and ensure that the result is  254 .
*/

using System;

class HexDecimal
{
    static void Main()
    {
        int hValue = 0xFE;

        Console.WriteLine("The result of {0:X} in decimal is: {0}.", hValue);

    }
}