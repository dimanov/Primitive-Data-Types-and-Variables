/*
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
*/

using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        int[] numbers = new int[255];


        //Get Cyrillic Encoding
        Console.OutputEncoding = Encoding.GetEncoding(1251);
        Console.WriteLine("ASCII Table");
        Console.WriteLine("Dec \t HEX \t Char");

        for (int i = 0; i < 255; i++)
        {
            numbers[i] = i;
            Console.WriteLine("{0}\t{0:X}\t{1:x}", numbers[i], (char)numbers[i]);
        }

    }
}