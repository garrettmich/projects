using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            RomanConverter converter = new RomanCoverter();
            string finalResult = converter.Convert(userNumber);
            Console.WriteLine

        }
    }
}
