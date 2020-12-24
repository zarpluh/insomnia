using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatrixSpiral
{
    static void Main()
    {
        //Console.Write("N = ");
        //int n = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[n, n];

        ////int[,] matrix = new int[3, 3];
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //        matrix[i, j] = ((i * n) + j)+1;


        //for (int i = 0; i < n; i++)

        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.WriteLine(matrix[i, j]);
        //    }

        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col < n + 1; col++)
            {
                Console.Write("{0} ", col + row);
            }
            Console.WriteLine();
        }
    }
}
