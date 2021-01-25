using System;
using System.Collections.Generic;

class GFG
{
    public static void Main()
    {
        double degrees = double.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        string outfit = "";
        string shoes = "";
        if (degrees >= 10 && degrees <= 18)
        {
            if (timeOfDay == "Morning")
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }

            else if (timeOfDay == "Aftrnoon" || timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

        }

        if (degrees > 18 && degrees <= 24)
        {
            if (timeOfDay == "Afternoon")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }

            else if (timeOfDay == "Мorning" || timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }

        if (degrees >= 25)
        {
            if (timeOfDay == "Мorning")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            if (timeOfDay == "Afternoon")
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            if (timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}
