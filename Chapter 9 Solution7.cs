using System;

namespace Chapter_9_Solution_7
{
    class Program
    {
    	static void ReverseNum(int num)
    	{
    		while(num!=0)
        	{
        		Console.Write(num%10);
            	num=num/10;
        	}
    	}
    	
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
        	ReverseNum(num);
            
        }
    }
}
