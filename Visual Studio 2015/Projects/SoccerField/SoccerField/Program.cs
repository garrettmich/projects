using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, what is the radius of the center circle on your soccer field, in feet?");
            string radius_string = Console.ReadLine();
            Console.WriteLine("Would you like red, blue, green, or yellow?");
            string color = Console.ReadLine().ToLower();
            double radius = Convert.ToDouble(radius_string);
            double area = Math.PI * Math.Pow(radius, 2);
            double bucket = 0;
            double cost = 0;

            if (color == "red")
            {
                bucket = Math.Ceiling(area / 100);
                cost = bucket * 25;
            }
            if (color == "blue")
            {
                bucket = Math.Ceiling(area / 120);
                cost = bucket * 28;
            }
            if (color == "green")
            {
                bucket = Math.Ceiling(area / 90);
                cost = bucket * 33;
            }
            if (color == "yellow")
            {
                bucket = Math.Ceiling(area / 70);
                cost = bucket * 22;
            }
            Console.WriteLine("It will take a total of " + bucket + " buckets to paint the " + radius + "' radius circle!");
            Console.WriteLine("It will cost $ " + cost + ".");
            Console.ReadLine(); 
             else
            {
                Console.WriteLine("We ain't got that!");
                Console.ReadLine();
            }
        }
       
        }
    }


// You are helping with a local soccer league
// They need to be able to paint their fields
// to mark the center circle. Different leagues
// have different sized circles, however. Make
// a program that will ask for the size of the
// circle (radius or diameter) and then tell them how much paint they
// need to cover the center circle. The paint
// they use covers about 100 sq ft per bucket.
// Make sure they have enough paint, it's ok
// if there is some extra left in the last
// bucket

// Show the output like this:
// It will take 8 buckets to paint the 15' radius circle

// Bonus: Different colors cover better than
// others. Let the user pick the color and show
// the result. The colors are as follows:
// Red = 100 sq ft/bucket
// Blue = 120 sq ft/bucket
// Green = 90 sq ft/bucket
// Yellow = 70 sq ft/bucket

// Extra Bonus: The colors also cost different
// amounts. Tell the user how much it will cost
// to paint their field.
// Red = 25$ / bucket
// Blue = 28$ / bucket
// Green = 33$ / bucket
// Yellow = 22$ / bucket