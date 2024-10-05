using System.Diagnostics.Contracts;
/*
  Given a string s, reverse only all the vowels in the string and return it.
  The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
   Example 1:
   Input: s = "IceCreAm"
   Output: "AceCreIm"
   Explanation:
   The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".
   
   Example 2:
   Input: s = "leetcode"
   Output: "leotcede"
  */

public class Solution
{
    public static bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) >= 0;

    public static string ReverseVowels(string s)
    {
        // Convert the string to a char array for easy manipulation
        char[] arr = s.ToCharArray();

        // Two pointers approach
        int p1 = 0, p2 = s.Length - 1;

        while (p1 < p2)
        {
            // Move the left pointer until a vowel is found
            if (!IsVowel(arr[p1]))
            {
                p1++;
            }
            // Move the right pointer until a vowel is found
            else if (!IsVowel(arr[p2]))
            {
                p2--;
            }
            // If both pointers point to vowels, swap them
            else
            {
                // Swap the vowels
                char temp = arr[p1];
                arr[p1] = arr[p2];
                arr[p2] = temp;

                // Move both pointers
                p1++;
                p2--;
            }
        }

        // Return the modified string
        return new string(arr);
    }

    public static void Main()
    {
        Console.WriteLine(ReverseVowels("leetcode"));
        Console.WriteLine(ReverseVowels("IceCreAm"));

    }
}
