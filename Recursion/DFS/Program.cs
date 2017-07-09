using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFSExample
{
    class DFSExample
    {
        static char[,] matrix = new char[7, 7]
{
{' ',' ','X','X',' ','X',' '},
{' ',' ',' ',' ','X',' ',' '},
{' ','X',' ',' ',' ',' ',' '},
{'X',' ',' ',' ',' ','X','X'},
{' ','X',' ',' ',' ',' ','X'},
{'X','X','X','X','X',' ',' '},
{' ',' ',' ',' ','X','E',' '}
};
        static void PrintPath()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static bool InRange(int row, int col)
        {
            bool rowInRange=row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }
        static void FindPathToExit(int row, int col)
        {
            if (!InRange(row,col))
            {
                return;
            }
            if (matrix[row, col] == 'E')
            {
                PrintPath();
            }
            if (matrix [row,col] != ' ')
            {
                return;
            }
            matrix[row, col] = 'v';
            FindPathToExit(row + 1, col);
            FindPathToExit(row - 1, col);
            FindPathToExit(row, col + 1);
            FindPathToExit(row, col - 1);
            matrix[row, col] = ' ';
        }
        static void Main(string[] args)
        {
            FindPathToExit(0, 0);
        }
    }
}