using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaySeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine();

            if (month == "December" || month == "January" || month "February")
            {
                Console.WriteLine("It was so cold");

            }
            if (month.Contains("March") | month.Contains("April"))
            {
                Console.WriteLine("oh, you mean pittsburgh's other summer");

            }
        }
    }
}
