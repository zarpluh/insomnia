using System;

namespace Chapter_5_Solution_2
{
    class Program
    {
        private static void FindElement(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i == 0) || (i == arr.Length - 1))
                {
                    continue;
                }
                else
                {
                    if ((arr[i - 1] < arr[i]) && (arr[i] > arr[i + 1]))
                    {
                        return i;

                    }
                    else
                        return -1;
                }
            }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindElement(arr, n));
        }
    }
}