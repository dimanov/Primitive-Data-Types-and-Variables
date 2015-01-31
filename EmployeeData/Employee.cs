/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

 * • First name
• Last name
• Age (0...100)
• Gender (m or f)
• Personal ID number (e.g. 8306112507)
• Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

using System;

class Employee
{
    static void Main()
    {
        string firstName = "";
        string lastName = "";
        byte age = 0;
        char gender = '\u0000';
        ulong personalId = 0u;
        uint employeeNumber = 0u;

        Console.WriteLine("The type of variable containing the first name of the employee is {0}.", firstName.GetType());
        Console.WriteLine("The type of variable containing the last name of the employee is {0}.", lastName.GetType());
        Console.WriteLine("The type of variable containing the age of the employee is {0}.", age.GetType());
        Console.WriteLine("The type of variable containing the gender of the employee is {0}.", gender.GetType());
        Console.WriteLine("The type of variable containing personal ID number of the employee is {0}.", personalId.GetType());
        Console.WriteLine("The type of variable containing the employee number of the employee is {0}.", employeeNumber.GetType());

    }
}