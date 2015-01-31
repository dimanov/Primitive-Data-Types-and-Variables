/*
* Declare a Boolean variable called  isFemale  and assign an appropriate value corresponding to your gender.
• Print it on the console.
*/

using System;

class YourGender
{
    static void Main()
    {
        string Gender;
        String mGender = "Male";
        String fGender = "Female";
        bool isFemale;

        Console.WriteLine("Please enter your gender (Male/Female):");
        Gender = Console.ReadLine();

        if (isFemale = Gender == mGender || Gender == fGender)
        {
            if (isFemale = Gender == fGender)
            {
                Console.WriteLine("Your Gender is {0}", fGender);
            }
            else
            {
                Console.WriteLine("Your gender is {0}", mGender);
            }
        }
        else
        {
            Console.WriteLine("Please next time enter your gender (Male/Female):");
        }
    }
}