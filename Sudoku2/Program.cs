using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sudoku2(char[][] grid)

            {
                bool isSudoku2 = true;
                HashSet<char> settest = new HashSet<char>();
                List<char> listRow = new List<char>();
                HashSet<char> setRow = new HashSet<char>();
                List<char> listCol = new List<char>();
                HashSet<char> setCol = new HashSet<char>();

                if (isSudoku2 == true)
                {

                    //Check row
                    for (int row = 0; row < grid.Rank; row++)
                    {
                        //populate each row
                        for (int j = 0; j < grid.Rank; j++)
                        {
                            listRow.Add(grid[row][j]);
                        }
                        //check each row for duplicate
                        for (int k = 0; k < grid.Rank; k++)
                        {
                            if (setRow.Add(listRow[k]) == false)
                            {
                                return false;
                            }
                        }
                    }

                    //Check column
                    for (int col = 0; col < grid.Rank; col++)
                    {
                        //populate each col
                        for (int j = 0; j < grid.Rank; j++)
                        {
                            listCol.Add(grid[j][col]);
                        }
                        //check each col for duplicate
                        for (int k = 0; k < grid.Rank; k++)
                        {
                            if (setCol.Add(listCol[k]) == false)
                            {
                                return false;
                            }
                        }
                    }

                    for (int i = 0; i < grid.Rank; i++)
                    {
                        for (int j = 0; j < grid.Rank; j++)
                        {
                            while (i <= 2 && j <= 2)
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while (i <= 2 && (j >= 3 && j <= 5))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while (i <= 2 && (j >= 6 && j <= 8))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while ((i >= 3 && i <= 5) && (j <= 2))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while ((i >= 3 && i <= 5) && (j >= 3 && j <= 5))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while ((i >= 3 && i <= 5) && (j >= 6 && j <= 8))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }

                            }
                            while ((i >= 6) && (j <= 2))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while ((i >= 6) && (j >= 3 && j <= 5))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                            while ((i >= 6) && (j >= 6))
                            {
                                if (settest.Add(grid[i][j]) == false)
                                {
                                    return false;
                                }
                            }
                        }
                        return true;
                    }
                    return true;
                }
                else
                {
                    return true;
                }

            }


        }
    }
}
