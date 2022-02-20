using System;

namespace Multiplication_table
{
    class Multi

    {
        public void multi()
        {
            Console.WriteLine("Enter the any Number :");
            int num = int.Parse(Console.ReadLine());
            for(int i= 1; i <=10 ; i++)
            {
                Console.WriteLine($"{num}*{num*i}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi obj = new Multi();
            obj.multi();
        }
    }
}
