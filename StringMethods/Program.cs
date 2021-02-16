using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take a string as an input
            Console.Write("Please input a string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("You input: {0}", inputString);

            // Take a character to find within the string
            Console.Write("Type a character to find the index:");
            string inputCharacter = Console.ReadLine();
            Console.WriteLine("You input : {0}", inputCharacter);
            int characterIndex = inputString.IndexOf(inputCharacter);
            Console.WriteLine("{0} can be found at index: {1}", inputCharacter, characterIndex);

            // Take first and last names as seperate inputs
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Your first name has been saved as " + firstName + ".");

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your last name has been saved as " + lastName + ".");
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Thank you, {0}. Your full name has been saved as {1}.", firstName, fullName);
        }
    }
}
