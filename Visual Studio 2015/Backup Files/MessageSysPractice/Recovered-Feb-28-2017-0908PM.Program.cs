using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Would you like to (s)ave or (r)etrieve a message or (e)xit?");
            string input;
            input = Console.ReadLine().ToUpper();
            
            string[] message = new string[5];

            while (input != "E")
            {
                if (input == "S")
                {
                    Console.WriteLine("Enter your message, please.");
                    message[i] = Console.ReadLine();
                    i++;
                }
                if (input == "R")
                {
                    Console.WriteLine("Enter your ID, please.");
                    int i

                }
            }
               
        }
    }
}
