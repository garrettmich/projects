using System;

namespace Feb28.GameOfLife
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
            for (int i = 0; i < 20; i++) // first row
            {
                for (int j = 0; j < 20; j++)// first twenty in first row
                {
                    grid[2, 3] = 1;
                    grid[2, 4] = 1;
                    grid[2, 5] = 1;
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string stop = "s";
            while (stop != "e")
            {
                for (int i = 0; i < 20; i++)
                {

                    for (int j = 0; j < 20; j++)
                    {

                        if (grid[i, j] > 0 && grid[i, j] < 20)
                        {
                            if (grid[i, j] == 1 && grid[i, j + 1] == 1 && grid[i + 1, j] == 0 && grid[i + 1, j + 1] == 0)
                            {
                                grid[i, j] = 0;
                            }
                        }
                        Console.Write(grid[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("(e) to end.");
                stop = Console.ReadLine().ToLower();
            }




            /*
			int livecell = grid[2, 3] = 1;
			int livecell2 = grid[2, 4] = 2;
			int livecelll3 = grid[2, 5] = 3;
		

			for (int i = 0; i < 20; i++) // first row
			{
				for (int j = 0; j < 20; j++)// first twenty in first row
				{
					Console.Write(grid[i, j]);
				}
				Console.WriteLine();

			}
			Console.Clear();

			if (livecell2 == 2)
			{
				grid[2, 3] = 0;
				grid[1, 4] = 6;
				grid[3, 4] = 6;
				grid[2, 5] = 0;

			}
			*/





            /*
* int Ship1_x = Ship1array[0];
        int Ship1_y = Ship1array[1];
        int Ship2_x = Ship2array[0];
        int Ship2_y = Ship2array[1];
* Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
Any live cell with two or three live neighbours lives on to the next generation.
Any live cell with more than three live neighbours dies, as if by overpopulation.
Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
*/

        }
    }
}