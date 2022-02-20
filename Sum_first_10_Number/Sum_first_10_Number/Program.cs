using System;

namespace Sum_first_10_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0;
            Console.WriteLine("The first 10 Natural Numbers are:");
            for(a=1;a<=10; a++)
            {
               
                 sum = sum +a;
                Console.WriteLine("The sum of first 10 Natural Number is :");
                Console.WriteLine(sum);

            }
        }
    }
}
