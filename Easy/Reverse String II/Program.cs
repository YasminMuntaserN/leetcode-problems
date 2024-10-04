using System;
/*
       Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.
      If there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and leave the other as original.
      
      Example 1:
      Input: s = "abcdefg", k = 2
      Output: "bacdfeg"
      
      Example 2:
      Input: s = "abcd", k = 2
      Output: "bacd"
  */
class Program
{
    static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static string ReverseStr(string s, int k)
    {
        string newS = "";

        // Loop until s is shorter than 2 * k
        while (s.Length >= (2 * k))
        {
            string word = s.Substring(0, (2 * k));

            // Reverse the first k characters
            newS += Reverse(word.Substring(0, k));

            // Add the remaining k characters without reversing
            newS += word.Substring(k, k);

            // Remove the first 2 * k characters from s
            s = s.Substring(2 * k);
        }

        // If there are fewer than k characters left, reverse all of them
        if (s.Length < k)
        {
            newS += Reverse(s);
        }
        // If there are between k and 2k characters, reverse the first k characters
        else if (s.Length >= k && s.Length < (2 * k))
        {
            newS += Reverse(s.Substring(0, k)) + s.Substring(k);
        }

        return newS;
    }


    /*another soluation */
    public string ReverseStr(string s, int k)
    {
        char[] array = s.ToCharArray();
        for (int i = 0; i < s.Length; i += 2 * k)
        {
            int size = Math.Min(k, s.Length - i);
            Array.Reverse(array, i, size);
        }
        return new string(array);
    }


    static void Main()
    {
        string result = ReverseStr("abcdefg", 2);
        Console.WriteLine(result);
    }
}
