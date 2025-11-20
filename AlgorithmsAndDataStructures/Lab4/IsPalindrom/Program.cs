using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        if (IsPalindrome(text))
            Console.WriteLine("The string IS a palindrome.");
        else
            Console.WriteLine("The string is NOT a palindrome.");
    }

    static bool IsPalindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
                return false;

            i++;
            j--;
        }
        return true;
    }
}
