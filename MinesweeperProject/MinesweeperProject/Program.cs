using System;

namespace MinesweeperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Opening.Start();

            int grid_size = 10;

            // 2-D array of given size
            char[,] grid = new char[grid_size, grid_size];

            // Filling the array with '.'
            for (int i = 0; i < grid_size; i++)
                for (int j = 0; j < grid_size; j++)
                    grid[i, j] = '.'; //this will fill the columns and rows with a '.'

            numberGrid.Grid(grid_size, grid);

            int game = 0;
            //setting the start point at 0
            while (game == 0)
            {
                Bombs.RandomBomb(grid, grid_size);
                // Asking the player for coordinates
                Console.Write("Enter your X coordinate: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your Y coordinate: ");
                int y = Convert.ToInt32(Console.ReadLine());

                // the grid updated according to what the player corodinates.

                if (grid[x, y] == '*')  // replaces the bombs inside the grid
                {
                    // if player hits a bomb the value is updated to -1 
                    game = -1;
                }
                else
                {
                    grid[x, y] = CountMineAroundCell(grid, x, y);
                    //or else the '.' is being projected 
                }


                numberGrid.Grid(grid_size, grid);
            }

            // Displaying the appropriate message if player won 
            if (game == 1)
                Console.WriteLine("You win!");
            //or hit a bomb
            else if (game == -1)
                Opening.End();
          
        }
        //surrounding mines are checked and displayed the amounts of bombs nearby
        static char CountMineAroundCell(char[,] grid, int x, int y)
        {
            int counter = 0;
            if (grid[x - 1, y - 1] == '*')
            {
                counter++;
            }
            if (grid[x, y - 1] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y] == '*')
            {
                counter++;
            }

            if (grid[x - 1, y + 1] == '*')
            {
                counter++;
            }
            if (grid[x, y + 1] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y + 1] == '*')
            {
                counter++;
            }


            return counter.ToString().ToCharArray()[0];
            Console.WriteLine($"There are {counter} bombs near you");



        }


    }

}