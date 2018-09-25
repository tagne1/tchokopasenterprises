using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool sudoku2(char[][] grid)
            {
                int maxLength = grid.Length;
                int subArraySize = (int)Math.Sqrt(maxLength);
                bool sudo = true;
                HashSet<char> set = new HashSet<char>();
                HashSet<char> setRow = new HashSet<char>();
                HashSet<char> setCol = new HashSet<char>();
               
               

                //Check row
                for (int row = 0; row <subArraySize; row++)
                {
                    for (int j = 0; j < grid.Rank; j++)
                    {
                        if (setRow.Add(grid[row][j]) == false)
                        {
                            return false;
                        }
                    }
                }

                //Check column
                for (int col = 0; col < grid.Rank; col++)
                {
                    for (int j = 0; j < grid.Rank; j++)
                    {
                        if (setCol.Add(grid[j][col]) == false)
                        {
                            return false;
                        }
                    }
                }

                 for (Int32 i=0; i<subArraySize; i++) { 
                    for (int j = 0; j < subArraySize; j++) {
                       if (i <= 2 && j <= 2)
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if (i <= 2 && (j >= 3 && j <= 5))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if (i <= 2 && (j >= 6 && j <= 8))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if ((i >= 3 && i <= 5) && (j <= 2))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if ((i >= 3 && i <= 5) && (j >= 3 && j <= 5))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if ((i >= 3 && i <= 5) && (j >= 6 && j <= 8))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }

                        }
                        if ((i >= 6) && (j <= 2))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if ((i >= 6) && (j >= 3 && j <= 5))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                        if ((i >= 6) && (j >= 6))
                        {
                            if (set.Add(grid[i][j]) == false)
                            {
                                return false;
                            }
                        }
                    }
                    return sudo;
                }
                
            }
           
            Console.ReadLine();

        }
    }
}
