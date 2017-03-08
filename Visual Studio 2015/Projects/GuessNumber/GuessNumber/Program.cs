using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 40. What number am I thinking of? If you guess incorrectly, you will die!");

            int guess = Convert.ToInt32(Console.ReadLine());
            int[] my_array = { 3, 12, 8, 33, 2 };
            string temp = "";

            for (int i = 0; i < my_array.Length; i++)
            { 
                if (my_array[i] == guess)
                {
                    temp = "yay";
                    //Console.WriteLine("You're not dying!");

                }
            }
            //            if (array [i] == {  3, 12, 8, 33, 2});
            if (temp == "yay")
            {
                Console.WriteLine("You're not dying!");
            }
            else
            {
                Console.WriteLine("You're dying!");
            }
            Console.ReadLine();

 
        }
    }
}
