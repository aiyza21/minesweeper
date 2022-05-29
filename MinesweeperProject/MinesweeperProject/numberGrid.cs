using System;
namespace MinesweeperProject
{
	public class numberGrid
	{
        public static void Grid(int grid_size, char[,] grid)
        {
            // Displays a grid
            for (int i = 0; i < grid_size; i++)
            {
                for (int j = 0; j < grid_size; j++)
                    Console.Write(grid[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }


    }
}

