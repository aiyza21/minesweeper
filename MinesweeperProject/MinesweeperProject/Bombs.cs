using System;
namespace MinesweeperProject
{
    public class Bombs : numberGrid
    {
        //this function will create the bombs randomly
        public static char[,] RandomBomb(char[,] grid, int grid_size)
        {
            Random rnd = new Random();
            //loop will be created that will run the bomb
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    int xbomb = rnd.Next(0, grid_size);
                    int ybomb = rnd.Next(0, grid_size);
                    int bomb = grid[a, b];
                    grid[a, b] = grid[xbomb, ybomb];
                    //this will assign a cordinate using the x(row) and y(column)number.
                    grid[xbomb, ybomb] = bomb.ToString("*").ToCharArray()[0];
                    //Console.WriteLine();
                }
                
            }
            return grid;//plants it onto the grid
        }

    }
}
