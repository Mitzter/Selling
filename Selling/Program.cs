using System;
using System.Collections.Generic;

namespace Selling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];

            FillMatrix(bakery);
            int moneyRequired = 50;
            int moneyCollected = 0;
            List<int> pillarCoordinates = new List<int>();

            for (int i = 0; i < bakery.GetLength(0); i++)
            {
                for (int j = 0; j < bakery.GetLength(1); j++)
                {
                    
                    if (bakery[i, j] == 'O')
                    {
                        pillarCoordinates.Add(i);
                        pillarCoordinates.Add(j);
                    }
                }
            }
            while (!(moneyCollected >= moneyRequired))
            {
                string input = Console.ReadLine();
                
                int currentRow = 0;
                int currentCol = 0;
                
                
                for (int i = 0; i < bakery.GetLength(0); i++)
                {
                    for (int j = 0; j < bakery.GetLength(1); j++)
                    {
                        if (bakery[i,j] == 'S')
                        {
                            currentRow = i;
                            currentCol = j;
                        }
                        
                    }
                }
                
                if (input == "up")
                {
                    int rowToMove = currentRow - 1;
                    int colToMove = currentCol;
                    if (!ValidateIndexes(bakery, rowToMove, colToMove))
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        bakery[currentRow, currentCol] = '-';
                        break;
                    }
                    
                    if (char.IsDigit(bakery[rowToMove,colToMove]))
                    {
                        
                        int moneyToCollect = (int)Char.GetNumericValue(bakery[rowToMove, colToMove]);
                        moneyCollected += moneyToCollect;
                        bakery[currentRow, currentCol] = '-';
                        bakery[rowToMove, colToMove] = 'S';
                        
                    }
                    if (bakery[rowToMove,colToMove] == 'O')
                    {
                        if (bakery[rowToMove,colToMove] == bakery[pillarCoordinates[0], pillarCoordinates[1]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[2], pillarCoordinates[3]] = 'S';
                        }
                        else if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[2], pillarCoordinates[3]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[0], pillarCoordinates[1]] = 'S';
                        }
                    }
                    else
                    {
                        bakery[rowToMove, colToMove] = 'S';
                        bakery[currentRow, currentCol] = '-';
                    }
                }
                if (input == "down")
                {
                    int rowToMove = currentRow + 1;
                    int colToMove = currentCol;
                    if (!ValidateIndexes(bakery, rowToMove, colToMove))
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        bakery[currentRow, currentCol] = '-';
                        break;
                    }

                    if (char.IsDigit(bakery[rowToMove, colToMove]))
                    {
                        int moneyToCollect = (int)Char.GetNumericValue(bakery[rowToMove, colToMove]);
                        moneyCollected += moneyToCollect;
                        bakery[currentRow, currentCol] = '-';
                        bakery[rowToMove, colToMove] = 'S';

                    }
                    if (bakery[rowToMove, colToMove] == 'O')
                    {
                        if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[0], pillarCoordinates[1]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[2], pillarCoordinates[3]] = 'S';
                        }
                        else if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[2], pillarCoordinates[3]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[0], pillarCoordinates[1]] = 'S';
                        }
                    }
                    else
                    {
                        bakery[rowToMove, colToMove] = 'S';
                        bakery[currentRow, currentCol] = '-';
                    }

                }
                if (input == "left")
                {
                    int rowToMove = currentRow;
                    int colToMove = currentCol - 1;
                    if (!ValidateIndexes(bakery, rowToMove, colToMove))
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        
                        bakery[currentRow, currentCol] = '-';
                        break;
                    }

                    if (char.IsDigit(bakery[rowToMove, colToMove]))
                    {
                        int moneyToCollect = (int)Char.GetNumericValue(bakery[rowToMove, colToMove]);
                        moneyCollected += moneyToCollect;
                        bakery[currentRow, currentCol] = '-';
                        bakery[rowToMove, colToMove] = 'S';

                    }
                    if (bakery[rowToMove, colToMove] == 'O')
                    {
                        if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[0], pillarCoordinates[1]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[2], pillarCoordinates[3]] = 'S';
                        }
                        else if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[2], pillarCoordinates[3]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[0], pillarCoordinates[1]] = 'S';
                        }
                    }
                    else
                    {
                        bakery[rowToMove, colToMove] = 'S';
                        bakery[currentRow, currentCol] = '-';
                    }
                }
                if (input == "right")
                {
                    int rowToMove = currentRow;
                    int colToMove = currentCol + 1;
                    if (!ValidateIndexes(bakery, rowToMove, colToMove))
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        bakery[currentRow, currentCol] = '-';
                        break;
                    }

                    if (char.IsDigit(bakery[rowToMove, colToMove]))
                    {
                        int moneyToCollect = (int)Char.GetNumericValue(bakery[rowToMove, colToMove]);
                        moneyCollected += moneyToCollect;
                        bakery[currentRow, currentCol] = '-';
                        bakery[rowToMove, colToMove] = 'S';

                    }
                    if (bakery[rowToMove, colToMove] == 'O')
                    {
                        if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[0], pillarCoordinates[1]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[2], pillarCoordinates[3]] = 'S';
                        }
                        else if (bakery[rowToMove, colToMove] == bakery[pillarCoordinates[2], pillarCoordinates[3]])
                        {
                            bakery[rowToMove, colToMove] = '-';
                            bakery[currentRow, currentCol] = '-';
                            bakery[pillarCoordinates[0], pillarCoordinates[1]] = 'S';
                        }
                    }
                    else
                    {
                        bakery[rowToMove, colToMove] = 'S';
                        bakery[currentRow, currentCol] = '-';
                    }

                }
                
            }

            if (moneyCollected >= moneyRequired)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {moneyCollected}");
            PrintMatrix(bakery);
        }
        private static void FillMatrix(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[i, j] = rowData[j];
                }
            }
        }

        private static void PrintMatrix(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {

                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}", maze[i, j]));
                }
                Console.WriteLine();
            }
        }
        public static bool ValidateIndexes(char[,] squareMatrix, int row, int col)
        {
            return row >= 0 && row < squareMatrix.GetLength(0) && col >= 0 && col < squareMatrix.GetLength(1);
        }
    }
    
}
