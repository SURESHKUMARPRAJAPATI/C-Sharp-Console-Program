using System;

namespace Store_Number_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] a =new int[10];
            Console.WriteLine("Enter the Number");
            for(int j=0;j<10;j++)
            {
                a[j]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array value is");
            foreach(int i in a)     
                Console.WriteLine(i);

        }
    }
}
