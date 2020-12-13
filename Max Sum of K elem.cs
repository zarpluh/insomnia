using System;

class GFG
{
	
	public static void Main()
	{
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[n];
        for (int i = 0; i <n; i++)
        {
            //arr[i] = i;
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = n-1; i >=n-k; i--)
        {
            sum += arr[i];           
        }
        Console.WriteLine(sum);
    }
}
