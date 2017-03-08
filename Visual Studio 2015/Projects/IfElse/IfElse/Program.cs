using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            if (name.Length > 10)
            {
                Console.WriteLine("Hi, " + name + " you have a long name!");
            }
            if (name.Length < 10)
            { Console.WriteLine(" your name is short!"); }


            if (name.Contains("!")) 
                      {
                Console.WriteLine(" that is not relevant, " + name + ".");

            }


            Console.ReadLine();


        }
        
        }
    }

