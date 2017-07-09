using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearchExample
{
    class BFSExample
    {
        class Point
        {
            public int xCoordinate { get; set; }
            public int yCoordinate { get; set; }

            public Point(int x, int y)
            {
                xCoordinate = x;
                yCoordinate = y;
            }
        }

        static char[,] matrix = new char[7, 7]
        {
            {' ',' ','X','X',' ','X',' '},
            {' ','X',' ',' ','X',' ',' '},
            {' ','X','S',' ',' ',' ',' '},
            {'X',' ',' ',' ',' ','X','X'},
            {' ','X',' ',' ',' ',' ','X'},
            {'X','X','X','X','X',' ',' '},
            {' ',' ',' ',' ','X','E',' '}
        };

        static void BFS(Point startPoint)
        {
            Queue matrixPoints = new Queue();
            matrixPoints.Enqueue(startPoint);
            while (matrixPoints.Count != 0)
            {
                Point currentPoint = (Point)matrixPoints.Dequeue();
                if (currentPoint.xCoordinate - 1 >= 0)
                {
                    if (matrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] == 'E')
                    {
                        Console.WriteLine("We have found the exit!!!");
                        return;
                    }
                    if (matrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] == ' ')
                    {
                        matrix[currentPoint.xCoordinate - 1, currentPoint.yCoordinate] = 'V';
                        matrixPoints.Enqueue(new Point(currentPoint.xCoordinate - 1, currentPoint.yCoordinate));
                    }
                }
                if (currentPoint.xCoordinate + 1 < matrix.GetLength(0))
                {
                    if (matrix[currentPoint.xCoordinate + 1, currentPoint.yCoordinate] == 'E')
                    {
                        Console.WriteLine("We have found the exit!!!");
                        return;
                    }
                    if (matrix[currentPoint.xCoordinate + 1, currentPoint.yCoordinate] == ' ')
                    {
                        matrix[currentPoint.xCoordinate + 1, currentPoint.yCoordinate] = 'V';
                        matrixPoints.Enqueue(new Point(currentPoint.xCoordinate + 1, currentPoint.yCoordinate));
                    }
                }
                if (currentPoint.yCoordinate + 1 < matrix.GetLength(0)) { if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate + 1] == 'E') { Console.WriteLine("We have found the exit!!!"); return; } if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate + 1] == ' ') { matrix[currentPoint.xCoordinate, currentPoint.yCoordinate + 1] = 'V'; matrixPoints.Enqueue(new Point(currentPoint.xCoordinate, currentPoint.yCoordinate + 1)); } } if (currentPoint.yCoordinate - 1 >= 0)
                {
                    if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] == 'E')
                    {
                        Console.WriteLine("We have found the exit!!!");
                        return;
                    }
                    if (matrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] == ' ')
                    {
                        matrix[currentPoint.xCoordinate, currentPoint.yCoordinate - 1] = 'V';
                        matrixPoints.Enqueue(new Point(currentPoint.xCoordinate, currentPoint.yCoordinate - 1));
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                ShowMatrix();
            }
        }

        static void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Point startPoint = new Point(2, 2);
            BFS(startPoint);
        }
    }
}