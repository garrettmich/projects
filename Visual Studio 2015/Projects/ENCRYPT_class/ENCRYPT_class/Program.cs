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
            // What do you want to do?
            // S) Save a message
            // R) Retrieve a message
            // L) List back end data
            // Q) Quit

            string[] messages = new string[10];
            int x = 0;

            bool something = true;
            while (something == true)
            {
                // Show the menu option
                Console.WriteLine("What do you wish to do?\n");
                Console.WriteLine("S) Save a message \nR) Retrieve a message");
                Console.WriteLine("L) List back end data \nQ) Quit");


                // Get the option selected
                string menu_choice = Console.ReadLine().ToUpper();

                switch (menu_choice)
                {
                    case "S":
                        Console.WriteLine("What is your message?");
                        // get unencrypted
                        string unencrypted = Console.ReadLine();
                        // encrypt it
                        string encrypted = "";// something!

                        for (int j = 0; j < unencrypted.Length; j++)
                        {
                            encrypted = encrypted + (char)(unencrypted[j] + 5);
                        }

                        // save it to message store
                        messages[x] = encrypted;
                        Console.WriteLine("Your message ID is: " + x);
                        x = x + 1;
                        // x++;
                        // x += 1;
                        break;
                    case "R":
                        Console.WriteLine("What is the message id you wish to retrieve?");
                        int message_id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Your message is: ");
                        string user_message = messages[message_id]; //user_message is a string, which means it is an array of characters
                        for (int i = 0; i < messages[message_id].Length; i++)
                        {
                            Console.Write((char)(messages[message_id][i] - 5)); //we're looking at the string they requested and we are
                                                                                //looking at each individual character inside of that string that they requested
                        }
                        Console.WriteLine();
                        break;
                    case "L":
                        for (int i = 0; i < messages.Length; i++)
                        {
                            Console.WriteLine(messages[i]);
                        }
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for using my messaging system.");
                        something = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a correct option!");
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}