using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Scratch3
{
    class Program
    {
        static void Main(string[] args)
        {
            // What is your message?
            // > Hello
            // Your message in Morse Code is:
            // > .... . .-.. .-.. ---
            char[] chars = { 'a', 'b', 'c', 'd', 'e' };
            string[] morse = { ".-", "-...", "-.-.", "-..", "." };




            Console.WriteLine("What is your message?");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (message[i] == chars[j])
                    {
                        Console.Write(morse[j] + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}