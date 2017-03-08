using System;
using System.Collections.Generic;

namespace Braille
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<char, String> braille = new Dictionary<char, String>()
            {
                    {'A' , ".00000"},{'B' , "..0000"},{'C' , ".00.00"},
                {'D' , ".00..0"},{'E' , ".000.0"},{'F' , "..0.00"},
                {'G' , "..0..0"},{'H' , "..00.0"},{'I' , "0.0.00"},
                {'J' , "0.0..0"},{'K' , ".0.000"},{'L' , "...000"},
                {'M' , ".0..00"},{'N' , ".0...0"},{'O' , ".0.0.0"},
                {'P' , "....00"},{'Q' , ".....0"},{'R' , "...0.0"},
                {'S' , "0...00"},{'T' , "0....0"},{'U' , ".0.00."},
                {'V' , "...00."},{'W' , "0.0..."},{'X' , ".0..0."},
                {'Y' , ".0...."},{'Z' , ".0.0.."}, { ' ' , "   " },
            };

            Console.WriteLine("What is your message?");
            string message = Console.ReadLine().ToUpper();

            char[] firstline = new char[100];
            char[] secondline = new char[100];
            char[] thirdline = new char[100];

            int counter = 0;

            foreach (char i in message)
            {
                char[] temporary = braille[i].ToCharArray();
                firstline[counter] = temporary[0];
                firstline[counter + 1] = temporary[3];
                firstline[counter + 2] = ' ';
                secondline[counter] = temporary[1];
                secondline[counter + 1] = temporary[4];
                secondline[counter + 2] = ' ';
                thirdline[counter] = temporary[2];
                thirdline[counter + 1] = temporary[5];
                thirdline[counter + 2] = ' ';

                counter = counter + 3;
            }

            Console.WriteLine(string.Join("", firstline));
            Console.WriteLine(string.Join("", secondline));
            Console.WriteLine(string.Join("", thirdline));

        }
    }
}