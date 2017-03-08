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
            Dictionary<char, string> morse_list = new Dictionary<char, string>();
            morse_list.Add('a', ".-");
            morse_list.Add('b', "-...");
            morse_list.Add('c', "-.-.");
            morse_list.Add('d', "-..");



            Console.WriteLine("What is your message?");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                {
                    char current_letter = message[i];
                    Console.Write(morse_list[current_letter] + " " ); //when writign write, everything comes out side by side and writeline makes then list down


                    /*     for (int j = 0; j < message.Length; j++)
                     if (message[i] == chars[j])
                     {
                         Console.Write(morse[0] + " ");
                     }

                     else if (message[i] == chars [1])
                     {
                         Console.Write(morse[1] + " ");
                     }
                     else if (message[i] == chars [2])
                     {
                         Console.Write(morse[2] + " ");
                     }
                     else if (message[i] == 'd')
                     {
                         Console.Write("-.. ");*/
                }
            }
            Console.ReadLine();
        }
    }
}