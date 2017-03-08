using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaySeasion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool should_i_loop = true;
            int counter = 0;
            
            
                Console.WriteLine("What month if your birthday?");
                string month = Console.ReadLine();
                while (month != "September")
                {
                Console.WriteLine("What month if your birthday?");
                month = Console.ReadLine();
                counter = counter + 1;
            }
            


        }
    }
}