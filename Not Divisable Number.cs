using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n+1];
            for (int i = 1; i <=n; i++)
            {
                arr[i] = i ;
                //arr[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i <= n; i++)
            {
                if ((arr[i] % 3 != 0) && (arr[i] % 7 != 0))
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
