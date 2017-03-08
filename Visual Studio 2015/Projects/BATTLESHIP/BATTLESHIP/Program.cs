using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipSession3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create grid variable name
            int[,] grid;
            // Allocate memory for grid
            grid = new int[8, 8];

            // Fill grid with water
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grid[i, j] = 0;
                }
            }

            // Place Ships
            /*grid[1, 3] = 1;
             grid[4, 1] = 1;
             grid[6, 6] = 1;*/
            //We're going to put random ships in, below. Above works too.
            Random rnd;
            rnd = new Random();

            for(int i =0; i < 5; i++)
            {
                int random_x = rnd.Next(7); //this returns an integer between 0 and 7
                int random_y = rnd.Next(7);
                grid[random_y, random_x] = 1;
            }
            while (true)
            {
                // Draw Grid
                Console.Clear();
                Console.WriteLine("     0  1  2  3  4  5  6  7  ");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(" " + i + " ");
                    for (int j = 0; j < 8; j++)
                    {
                        if (grid[i, j] == 0) // Open Water
                        {
                            Console.Write("[0]"); //Console.WrtieLine(); instead of Console.Write it hits enter in the background for the user. Console.write(grid[i,j]); is printing the grid
                        }
                        else if (grid[i, j] == 1) // Has a ship 
                        {
                            Console.Write("[-]");
                        }
                        else if (grid[i, j] == 2) // Blown up ship
                        {
                            Console.Write("[*]");
                        }
                    }
                    Console.WriteLine();
                }

                // Get Input
                /*Console.WriteLine("Enter the Y coordinate to start");
                int y = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the X coordinate to shoot");
                int x = Convert.ToInt16(Console.ReadLine());
                */
                Console.WriteLine("Enter the coordinates to shoot. EX: 2 , 3");
                string input = Console.ReadLine();
                string[] coords = input.Split(','); //strings are an array of characters, but the chracters are all assigned to a number, so it is actually an array. ex: "john, jean, table". split(' , ')
                                                      // so it will be ["John, "Jean", "table"] so earlier when he stated values earlier, 0, 1, 2... those are now assigned to those numbers as an array.
                                                      //string.split gives you an array of strings
                int x;
                int y;
                y = Convert.ToInt16(coords[0]);
                x = Convert.ToInt16(coords[1]);

                

                // Update Grid
                if (grid[y, x] == 1)
                {
                    // hit!
                    Console.WriteLine("You hit!");
                    grid[y, x] = 2;
                }
                else
                {
                    // miss!
                    Console.WriteLine("You missed!");
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }

        }
    }
}