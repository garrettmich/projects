using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello" + "World");
            Console.WriteLine("Hello" + 2);
            Console.WriteLine("Hello" + 2 / 2 + "World");
            Console.WriteLine("Hello" + 2 + 2 + "World");

            Console.WriteLine("Hello World".Length);
            Console.WriteLine("Hello World".ToUpper());
            Console.WriteLine("Hello".Length + "A long sentence.".Length);
            Console.WriteLine(Math.PI * (4 * 2)); // Diameter of a circle with
            Console.WriteLine("Hello World".Replace("World", "Universe"));


            Console.WriteLine("AAAAA".Replace("A", "Hello World "));
            Console.ReadLine();


            int a; // We nopw have an integer named 'a', with no
            a = 2; // 'a' now has a number

            int b = 2


            Console.WriteLine("b = " + b);
            // You don't have to have single values to the right

            b = 2 * 2 + 18;

            // This is also true when declaring a variable

            int c = 99 + (4 / 2 + 5);
            Console.WriteLine("c =" + c); )


              a = b = c = 10;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);


            // Strings work the same way

            string X = "This is a string";
            Console.WriteLine(X);

            // But now what happens if you do this?

            string someString = "string!";
            int number = 4;
            // someStrong = number; // weird, right? + has an 
            someString = someString + number; // this works
            // as we get further, we'll look into functions,
            // but basically 

            someString = "23";
            number = Convert.ToInt16(someString);

            //someString = "not a number";
            //number = Convert.ToInt16(someString); 
            // Console.ReadLine();

            // What about doing something like this?

            string userAnswer;
            userAnswer = Console.ReadLine();

            Console.WriteLine("Here is what you typed: " + userAnswer
                //number = Convert.ToInt16(someString);
                Console.ReadLine();
}
    }
}




