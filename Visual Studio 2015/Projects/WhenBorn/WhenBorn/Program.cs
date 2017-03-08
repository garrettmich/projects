using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenBorn
{
    class Program
    {
        static void Main(string[] args)
        { 
            int counter = 10;
            while (counter == 10)
           
        {
            Console.WriteLine("Hello! What month were you born in?");
            string word = Console.ReadLine();
            if (word.Contains("March")||word.Contains("April")||word.Contains("May")||word.Contains("June")||word.Contains("July"))
                Console.WriteLine("You were born in Spring!");
            counter = counter 10
            Console.ReadLine();
        }

           else if (word.Contains("July")||word.Contains("August") ||word.Contains("September"))
               {
            Console.WriteLine("You were born in Summer!");
            Console.ReadLine();
            }
        }
    }
}
