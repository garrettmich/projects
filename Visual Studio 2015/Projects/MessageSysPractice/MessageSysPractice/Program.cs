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
            Console.WriteLine("Would you like to save or print a message, person or persons?");
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
                if (input == "P")
                {
                    Console.WriteLine("Enter your message number (Number 0 is the first message)");
                    int messageNumber = Console.Read();
                    Console.WriteLine(message[messageNumber]);
                }
                Console.WriteLine("Would you like to save or print a message, person or persons?");
                input = Console.ReadLine().ToUpper();

            }


        }
    }
}
