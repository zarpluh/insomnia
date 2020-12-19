using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
                {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10,11,12}
                };
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-6}",matrix[row, col]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,-6}", matrix[i,j]);
                }
                Console.WriteLine();
            }                
        }
    }
}
