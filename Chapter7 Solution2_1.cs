using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        bool differenceFound = false;

        Console.WriteLine(
          "Input string for the first array of chars:");
        string charArray1 = Console.ReadLine();

        Console.WriteLine(
          "Input string for the second array of chars:");
        string charArray2 = Console.ReadLine();

        int counter = 0;

        //Compare   arrays
        while (counter < charArray1.Length &&
          counter < charArray2.Length)
        {
            char tempChar1, tempChar2;

            tempChar1 = SmallToCapital(charArray1[counter]);
            tempChar2 = SmallToCapital(charArray2[counter]);

            if (tempChar1 > tempChar2)
            {
                PrintResult(charArray1, charArray2, "After");
                differenceFound = true;
                break;
            }

            else if (tempChar1 < tempChar2)
            {
                PrintResult(charArray1, charArray2, "Before");
                differenceFound = true;
                break;
            }

            else counter++;
        }

        // If no differences found, cheking up to the length
        // of the smaller array, so the size of the arrays matters
        if (!differenceFound)
        {
            if (charArray1.Length == charArray2.Length)
            {
                Console.WriteLine("Arrays are identical!");
            }

            else if (charArray1.Length < charArray2.Length)
            {
                PrintResult(charArray1, charArray2, "Before");
            }

            else
            {
                PrintResult(charArray1, charArray2, "After");
            }
        }
    }

    private static void PrintResult(
      string charArr1, string charArr2, string relation)
    {
        Console.WriteLine("\"{0}\" is {2} \"{1}\" lexicographically.",
          charArr1, charArr2, relation);
    }

    private static char SmallToCapital(char ch)
    {
        // Check for small english or cyrillic letter
        // and returns corresponding capital letter,
        // else return same symbol
        if ((ch >= 'a' && ch <= 'z') ||
          (ch >= 'а' && ch <= 'я'))
            return Convert.ToChar(ch - 32);
        else return ch;
    }
}
