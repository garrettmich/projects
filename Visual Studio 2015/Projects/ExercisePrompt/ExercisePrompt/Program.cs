using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePrompt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello there, " + name);

            Console.WriteLine("Age?");
            string age;
            age = Console.ReadLine();
            int age_as_int;
            age_as_int = Convert.ToInt16(age);
            age_as_int = age_as_int + 5;
            Console.WriteLine("You will be " + age_as_int + " in 5 years");

            //number = Convert.ToInt16(someString);
            Console.ReadLine();

        }
    }
}
