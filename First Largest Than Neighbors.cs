using System;
using System.Linq;

class GFG
{
	
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		for (int i = 0; i < n; i++)
		{
			if ((i == 0) || (i == n - 1))
			{
				continue;
			}
			else
			{
				if ((arr[i - 1] < arr[i])&&(arr[i]>arr[i+1]))
				{
					Console.WriteLine(i);
					break;
				}
			}
		}
	}
}
