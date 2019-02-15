using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        int i = 0;
        int j = word.Length - 1;
        word = word.ToLower();
        while (i < j)
        {
            if (word[i] != word[j])
                return false;

            i++;
            j--;
        }

        return true;

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }

}
