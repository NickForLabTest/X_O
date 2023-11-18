using System;

namespace X_O
{
    
    
    internal class Program
    {
        
        class game
        {
            char[,] grid = new char[3, 3];

            void print_array()
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(0); j++)
                    {
                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            void init()
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(0); j++)
                    {
                        grid[i, j] = '-';
                    }
                }
            }
            public game()
            {
                init();
            }

            public void start_game()
            {
                bool turn = false;
                while (true)
                {
                    if (turn == false)
                    {
                        Console.WriteLine("Set X to: ");
                        string[] tokens = Console.ReadLine().Split();
                        int row, column;
                        row = int.Parse(tokens[0]);
                        column = int.Parse(tokens[1]);
                        grid[row - 1, column - 1] = 'X';
                        print_array();
                    }
                    else
                    {
                        Console.WriteLine("Set 0 to: ");
                        string[] tokens = Console.ReadLine().Split();
                        int row, column;
                        row = int.Parse(tokens[0]);
                        column = int.Parse(tokens[1]);
                        grid[row - 1, column - 1] = 'O';
                        print_array();
                    }
            
                    turn = !turn;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            game g = new game();
            g.start_game();
        }
        
    }
}