using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)//counter
            {
                if (number % 3 == 0 && number % 5 == 0)//if number is divided by 3 with remainder of 3, then it is divisible by 3. it is zero.
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
//don't need number++ at the end             }
            Console.ReadLine();
        }
    }
}