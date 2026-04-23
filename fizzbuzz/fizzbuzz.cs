using System;
using System.Drawing;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (i = 1; i < 101; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press enter to complete");
            Console.ReadLine();
        }
    }
}
