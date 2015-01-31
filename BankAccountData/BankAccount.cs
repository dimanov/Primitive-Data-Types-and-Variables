/*
• A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
• Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "";
        string middleName = "";
        string lastName = "";
        decimal amount = 0M;
        string bankName = "";
        string personalIban = "";
        long cardNumber1 = 0L;
        long cardNumber2 = 0L;
        long cardNumber3 = 0L;

        Console.WriteLine("The type of variable containing the first name of the client is {0}.", firstName.GetType());
        Console.WriteLine("The type of variable containing the middle name of the client is {0}.", middleName.GetType());
        Console.WriteLine("The type of variable containing the last name of the client is {0}.", lastName.GetType());
        Console.WriteLine("The type of variable containing the age of the client is {0}.", amount.GetType());
        Console.WriteLine("The type of variable containing the gender of the cleint is {0}.", bankName.GetType());
        Console.WriteLine("The type of variable containing personal ID number of the client is {0}.", personalIban.GetType());
        Console.WriteLine("The type of variable containing the employee number of the client is {0}.", cardNumber1.GetType());
        Console.WriteLine("The type of variable containing the employee number of the client is {0}.", cardNumber2.GetType());
        Console.WriteLine("The type of variable containing the employee number of the client is {0}.", cardNumber3.GetType());
    }
}