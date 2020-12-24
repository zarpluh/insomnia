using System;
public class MatrixSpiral
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for ( int row = 0; row < n; row++)
        {
            for (int col = 1; col < n+1; col++)
            {
                Console.Write("{0} ",col+row);
            }
        Console.WriteLine();
            
        }
    }
}
