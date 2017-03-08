using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGardenBox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the length in feet of your garden box?");
            int Length = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("What is the width in feet of your garden box?");

            int Width = Convert.ToInt16(Console.ReadLine());

            int Area = 2 * (Width * Length);
            int Perimeter = Width * Length;

            Console.WriteLine("The area of your garden box is " + Area + ".");
            Console.WriteLine("The perimeter of your garden box is " + Perimeter + ".");

            int Carrots = Area;
            int Corn = Area / 3;
            double Beets = Area / 1.5;

            Console.WriteLine("You can plant " + Carrots + " amount of carrots.");
            Console.WriteLine("You can plant " + Corn + " amount of corn.");
            Console.WriteLine("You can plant " + Beets + " amount of beets.");

            Console.ReadLine();

            //number = Convert.ToInt16(
        }
    }
}
