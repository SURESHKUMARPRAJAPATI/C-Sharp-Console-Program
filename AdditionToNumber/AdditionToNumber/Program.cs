using System;

namespace AdditionToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first No.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second No.");
            int b = int.Parse(Console.ReadLine());
           int sum = a + b;
            Console.WriteLine("Sum is : = " + sum);
        }
    }
}
