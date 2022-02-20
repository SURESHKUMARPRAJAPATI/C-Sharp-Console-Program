using System;

namespace Even_Or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter s Number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is an even Number");
            }
            else
            {
                Console.WriteLine("It is an odd Number");
            }
        }
    }
}
