using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("You input: {0}", inputString);
            Console.Write("Type a character to find the index:");
            char inputChar = (char)Console.Read();
            Console.WriteLine("You input : {0}", inputChar);
        }
    }
}
