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
            char inputCharacter = (char)Console.Read();
            Console.WriteLine("You input : {0}", inputCharacter);
            int characterIndex = inputString.IndexOf(inputCharacter);
            Console.WriteLine("{0} can be found at index: {1}", inputCharacter, characterIndex);

        }
    }
}
