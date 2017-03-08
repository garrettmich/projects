using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Scratch3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gridsize = 20;

            // create our grid
            int[,] grid = new int[gridsize, gridsize];

            // Add a known shape
            grid[5, 5] = 1;
            grid[5, 6] = 1;
            grid[5, 7] = 1;

            while (true)
            {
                // create a new temporary grid
                int[,] new_grid = new int[gridsize, gridsize];

                // do some work to temp grid
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        new_grid[i, j] = grid[i, j];
                    }
                }

                // copy temp grid over original grid
                grid = new_grid;


                // clear the screen
                Console.Clear();
                // print our grid
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write(grid[i, j]);
                    }
                    Console.WriteLine();
                }

                // Wait until enter is hit
                Console.ReadLine();
            }
        }
    }
}