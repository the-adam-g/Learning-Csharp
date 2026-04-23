using System;
using System.Drawing;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* this is a cool multi line comment
             writeline creates a new line whereas write doesnt */
            Console.WriteLine("Do you wanna know what 7+ 3 is?");
            Console.Write("Its: "); Console.WriteLine(7 + 3); //change this to be whatever you want
            //put writeline on the last line to create a new line after the output

            // lets define a variable
            string user = "Adamg";
            Console.WriteLine("Welcome concat " + user); //concatenation is done like this
            Console.WriteLine($"Welcome interpolate {user}"); //interpolation is done like this, similar to python
            int num1 = 7;
            int num2 = 3;
            Console.WriteLine($"! 7 + 3 using variables is: {num1 + num2}");
            const int num3 = 4; //this cant be changed
            Console.WriteLine($"Permanent number: {num3}");
            int num5 = 7, num6 = 3; //multiple variables can be defined on one line
            double pi = 3.14; //eseentially a float
            //casting
            int badpi = (int)pi;
            Console.WriteLine($"Pi is: {pi} but when casted to an int its: {badpi}");
            Convert.ToString(pi); //this is how you convert to a string, there are many other conversions like ToInt32, ToDouble, etc
            Console.WriteLine("------------------------------");
            Console.WriteLine("Addition program");
            Console.WriteLine("Enter number 1");
            string x = Console.ReadLine();
            int x1 = Convert.ToInt32(x); //this is how you convert a string to an int
            Console.WriteLine("Enter number 2");
            string y = Console.ReadLine();
            int y1 = Convert.ToInt32(y);
            Console.WriteLine($"{x1 + y1}");
            int sum = x1 + y1;
            Console.WriteLine(x1 > y1);
        }
    }
} 
