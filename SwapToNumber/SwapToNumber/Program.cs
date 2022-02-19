using System;

namespace SwapToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("After the swapping Number is " + a);
            Console.WriteLine("After the swapping Number is " + b);
        }
    }
}
