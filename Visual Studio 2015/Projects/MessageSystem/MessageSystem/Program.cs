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
            int = 0;
            Console.WriteLine("Would you like to save or retrieve a message, person or persons?");
            string User_Choice;
            User_Choice = Console.ReadLine().ToUpper();
            string[] myarray = new string[5];
            if (User_Choice == "SAVE")
            {
                Console.WriteLine("Enter your message, please.");
                myarray[1] = Console.ReadLine();
            }
            if (User_Choice == "RETRIEVE")
            {
            }
        }
    }
}
