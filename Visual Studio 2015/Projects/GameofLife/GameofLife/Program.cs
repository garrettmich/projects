using System;

namespace BATTLESHIP_FIRST_TAKE
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] grid = new int[20, 20];




            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    grid[i, j] = 0;
                }
            }
            grid[2, 3] = 3;
            grid[2, 4] = 3;
            grid[2, 5] = 3;




            for (int i = 0; i < 20; i++)//first row
            {
                for (int j = 0; j < 20; j++)//first twenty in first row
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}