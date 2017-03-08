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
            /*
             * Would you like to (S)tore a message or (R)etrieve a message or e(x)it?
             * > S
             * What is your message?
             * > I am testing this message system!
             * Saved! Your message ID is 0
             * Would you like to (S)tore a message or (R)etriev a message?
             * > R
             * What is the message ID?
             * > 0
             * The message is: I am testing this message system!
             * 
             * */

            /*Dictionary <char, char> dictionary = new Dictionary<char,char>();

            dictionary.Add('a', 'b');
            dictionary.Add('b', 'c');
            dictionary.Add('c', 'd');
            dictionary.Add('d', 'e');
            dictionary.Add('e', 'f');
            dictionary.Add('f', 'g');
            dictionary.Add('g', 'h');
            dictionary.Add('h', 'i');
            dictionary.Add('i', 'j');
            dictionary.Add('j', 'k');
            dictionary.Add('k', 'l');
            dictionary.Add('l', 'm');
            dictionary.Add('m', 'n');
            dictionary.Add('n', 'o');
            dictionary.Add('o', 'p');
            dictionary.Add('p', 'q');
            dictionary.Add('q', 'r');
            dictionary.Add('r', 's');
            dictionary.Add('s', 't');
            dictionary.Add('t', 'u');
            dictionary.Add('u', 'v');
            dictionary.Add('v', 'w');
            dictionary.Add('w', 'x');
            dictionary.Add('x', 'y');
            dictionary.Add('y', 'z');
            dictionary.Add('z', 'a');*/


            char[] alph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z'};

            string[] asci = { "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110",
            "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123"};

           string[] message;
            message = new string[5];
            message[0] = " ";
            message[1] = " ";
            message[2] = " ";
            message[3] = " ";
            message[4] = " ";
            

            int i = 0;
            bool stop = false;
            while (stop == false)
            {
                Console.WriteLine("Would you like to (s)tore a message or (r)etrieve a message or e(x)it?");
                string response = Console.ReadLine().ToLower();

                if (response == "s")
                {
                    // Saving a message
                    Console.WriteLine("What is your message?");
                    message[i] = Console.ReadLine();
                    Console.WriteLine("Saved! Your message ID is " + i);
                    i++;
                }
                else if (response == "r")
                {
                    // Retrieving a message
                    Console.WriteLine("What is your message id?");
                    string message_id = Console.ReadLine();
                    int message_id_int = Convert.ToInt32(message_id);
                    Console.WriteLine("The message is: " + message[message_id_int]);

                    //message has been saved as a number
                   
                }
                else if (response == "l")
                    {
                    Console.WriteLine(" ");
                    string message_list = Console.ReadLine();
                    int message_list_int = Convert.ToInt32(message_list);
                    Console.WriteLine("The message is: " + message[message_list_int]);
                    //if you have an array you will always need a for statement (loop) to cycle through

                }
                else if (response == "x")
                {
                    stop = true;
                }
                else
                {
                    // Typed anything else
                    Console.WriteLine("I didn't understand what you typed.");
                }
            }





            Console.ReadLine();
        }
    }
}