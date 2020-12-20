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
            int[] arr = new int[20] ;
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine("[i] = {0}      {1}",i, arr[i]);
            }
        }
    }
}
