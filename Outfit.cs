using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
        	double degrees=double.Parse(Console.ReadLine());
        	string timeOfDay=Console.ReadLine();
        	string outfit="";
        	string shoes="";
        	if(degrees>=10 && degrees<=18)
        	{
        		if(timeOfDay=="Morning")
        		{
        			outfit="Sweatshirt";
        			shoes="Sneakers";
        		}
        	
        	else if(timeOfDay=="Aftrnoon" || timeOfDay=="Evening")
        	{
        		outfit="Shirt";
        		shoes="Moccasins";
        	}
        	
        	if(degrees>18 && degrees<=24)
        	{
        		if(timeOfDay=="Morning") || (timeOfDay=="Evening")
        		{
        			outfit="Shirt";
        			shoes="Moccasins";
        		}
        	
        	else if(timeOfDay=="Aftrnoon")
        	{
        		outfit="T-Shirt";
        		shoes="Sandals";
        	}
        	
        	
        	Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
