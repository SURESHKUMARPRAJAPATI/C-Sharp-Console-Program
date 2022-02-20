using System;

namespace Find_Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int c = int.Parse(Console.ReadLine());
            {
                if(a>b && a>c)
                {
                    Console.WriteLine("The largest No. is = " + a);
                }
                else if(b>a && b>c)
                {
                    Console.WriteLine("The largest No. is = " + b);
                }
                else
                {
                    Console.WriteLine("The largest No. is = " + c);
                }
            }
        }
    }
}
