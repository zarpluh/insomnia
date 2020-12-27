using System;

namespace ConsoleApp1
{
    class Program
    {
        static int binarySearch(int[] arr, int l,
                            int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
 
                if (arr[mid] == x)
                    return mid;

                 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }
             
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Emter number of the elemrnts: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter searched number: ");
            int x = int.Parse(Console.ReadLine());

            Array.Sort(array);

            int result = binarySearch(array, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }
    }
}
