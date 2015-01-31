/*
* Declare five variables choosing for each of them the most appropriate of the types  
* byte, sbyte, short, ushort, int, uint, long, ulong  to represent the following values:  
* 52130, -115, 4825932, 97, -10000 .
• Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

using System;

class Variables
{
    static void Main()
    {
        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;

        Console.WriteLine("The first value {0} is saved in {1} type of variables.", var1, var1.GetType());
        Console.WriteLine("The second value {0} is saved in {1} type of variables.", var2, var2.GetType());
        Console.WriteLine("The third value {0} is saved in {1} type of variables.", var3, var3.GetType());
        Console.WriteLine("The fourth value {0} is saved in {1} type of variables.", var4, var4.GetType());
        Console.WriteLine("The fifth value {0} is saved in {1} type of variables.", var5, var5.GetType());
        
    }
}