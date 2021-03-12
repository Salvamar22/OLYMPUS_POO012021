using System;

namespace Lab01
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals {LestNumbers(a,b)}");


        }
        public static int LestNumbers(int a, int b){

            return a - b;
        }
    }
}