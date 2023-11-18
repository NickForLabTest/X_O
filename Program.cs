using System;

namespace X_O
{
    
    
    internal class Program
    {
        
        class game
        {
            char[,] grid = new char[3, 3];

            bool check(int row,int column)
            {
                if ((row == 0 && column == 0) || (row == 1 && column == 1) || (row == 2 && column == 2))
                {
                    if (grid[0, 0] == grid[1, 1] && grid[0, 0] == grid[2, 2]) return true;
                }
                
                if ((row == 2 && column == 0) || (row == 1 && column == 1) || (row == 0 && column == 2))
                {
                    if (grid[2, 0] == grid[1, 1] && grid[2, 0] == grid[0, 2]) return true;
                }

                if (grid[row, 0] == grid[row, 1] && grid[row, 0] == grid[row, 2]) return true;
                
                if (grid[row, 0] == grid[row, 1] && grid[row, 0] == grid[row, 2]) return true;

                if (grid[0, column] == grid[1, column] && grid[0, column] == grid[2, column]) return true;
                return false;
            }
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
                    char insert;
                    insert = turn==true? 'O':'X';
                    {
                        Console.WriteLine("Set " + insert + " to:");
                        string[] tokens = Console.ReadLine().Split();
                        int row, column;
                        row = int.Parse(tokens[0]);
                        column = int.Parse(tokens[1]);
                        grid[row - 1, column - 1] = insert;
                        print_array();
                        if (check(row - 1, column - 1) == true)
                        {
                            Console.WriteLine("We have a winner!");
                            break;
                        }
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
