using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lotto_Gen_V1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool arraysEqual = true;
            if (n != m)
            {
                Console.WriteLine("Arrays are different!");
            }
            int[] arra = new int[n];
            int[] arrb = new int[m];

            for (int i = 0; i < n; i++)
            {
                arra[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                arrb[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arra.Length; i++)
            {
                if (arra[i] != arrb[i])
                {
                    Console.WriteLine("\nArrays are different.");
                    arraysEqual = false;
                    break;
                }
            }
            if (arraysEqual) Console.WriteLine("\nArrays are the same.");
        }
    }
}
