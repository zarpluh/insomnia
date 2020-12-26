using System;

namespace Chapter_7_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tempCounter = 1, foundNumber = 0;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCounter++;
                }
                else
                    tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }
            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
        }
    }
}
