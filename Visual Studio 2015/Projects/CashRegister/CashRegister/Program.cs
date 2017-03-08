using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeddyBearCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the cost, good sir/madam?");
            string cost = Console.ReadLine();
            decimal decimalcost = Convert.ToDecimal(cost);

            Console.WriteLine("Thank you kindly. How much money in cash are you about to hand to me right now to pay for it?");
            string cash = Console.ReadLine();
            decimal decimalcash = Convert.ToDecimal(cash);

            decimal changeback = (decimalcash - decimalcost);

            Console.WriteLine("Your exact change is " + changeback);

            int numberoftwenties = 0;
            int numberoftens = 0;
            int numberoffives = 0;
            int numberofones = 0;
            int numberofquarters = 0;


            while (changeback >= 20)
            {
                numberoftwenties = numberoftwenties + 1;
                changeback = changeback - 20;

            }

            while (changeback >= 10)
            {
                numberoftens = numberoftens + 1;
                changeback = changeback - 10;
            }



            while (changeback >= 5)
            {
                numberoffives = numberoffives + 1;
                changeback = changeback - 5;
            }


            while (changeback >= 1)
            {
                numberofones = numberofones + 1;
                changeback = changeback - 1;
            }



            while (changeback >= 0.25m)
            {
                numberofquarters = numberofquarters + 1;
                changeback = changeback - .25m;
            }




            if (numberoftwenties > 0)
            {
                if (numberoftwenties == 0)
                    Console.WriteLine("Please accept " + numberoftwenties + " twenty dollar bill into your hand and/or cash receptacle device");
            }
            else

            if (numberoftens > 0)
            {
                if (numberoftens == 0)
                {
                    Console.WriteLine("Please accept " + numberoftens + " ten dollar bill into your hand and/or cash receptacle device");
                }
                else

            if (numberoffives > 0)
                {
                    Console.WriteLine("Please accept " + numberoffives + " five dollar bill into your hand and/or cash receptacle device");
                }

                if (numberofones > 0)
                {
                    if (numberofones == 1)
                    {
                        Console.WriteLine("Please accept " + numberofones + " one dollar bill into your hand and/or cash receptacle device");
                    }
                    else


                if (numberofquarters > 0)
                    {
                        if (numberofquarters == 0)
                        {
                            Console.WriteLine("Please accept " + numberofquarters + " quarter into your hand and/or coin receptacle device");
                        }
                        else
                        {
                        }
                    }

                    Console.ReadLine();

                }
                Console.ReadLine();
            }
        }
    }
}
