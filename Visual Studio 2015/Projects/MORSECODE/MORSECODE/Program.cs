using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORSECODE
{
    class Program
    {
        static void Main(string[] args)
        {
            // What is your message?
            // > Hello
            // Your message in Morse Code is:
            // > .... . .-.. .-.. ---

            Console.WriteLine("I'm going to translate your message into Morse Code. What is your message?");
            string message = Console.ReadLine().ToLower();
            char[] message_array = message.ToCharArray();

            Console.WriteLine("Your message in Morse Code is: ");
            Console.ReadLine();


            /* string message = "Hello";
             Console.WriteLine(message[1]);
             char[] message_array = message.ToCharArray();
             Console.WriteLine(message_array[1]);
             Console.ReadLine();*/


        }
    }
}
