using System;

namespace ConverStringInLowerCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence in Upercase");
            string a = Console.ReadLine();
            Console.WriteLine("The Lowercase Sentence is = " + a.ToLower());
        }
    }
}
