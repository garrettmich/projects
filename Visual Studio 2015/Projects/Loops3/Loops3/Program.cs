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
        int number = 1;//counter
        while(number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)//if number is divided by 3 with remainder of 3, then it is divisible by 3. it is zero.
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
                number = number + 1;//two other ways to write this: number += 1; or number(number can be called anything, like 'counter')++ so, number++; if you write is number += 5; it means it will count by every 5
            }
            Console.ReadLine();
        }
    }
}