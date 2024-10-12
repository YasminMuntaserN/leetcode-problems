using System.Collections.Generic;

public class Solution
{
    /* public static bool WordPattern(string pattern, string s)
     {
         string [] arr = s.Split(" ");
         if (pattern.Length != arr.Length) return false;

         Dictionary<char ,string> keyValuePairs = new Dictionary<char ,string>();
         HashSet<string> usedWords = new HashSet<string>(); // this to nsure each word maps to only one pattern character

         int j = 0; int i = 0;

         while (i< pattern.Length) 
         {


             if (!keyValuePairs.ContainsKey(pattern[i]))
             {
                 keyValuePairs.Add(pattern[i], arr[j]);
                 usedWords.Add(arr[j]);
                 j++; i++;
                 continue;
             }

             if (keyValuePairs[pattern[i]] != arr[j]) return false;

             j++;i++;
         }

         if (keyValuePairs.Count() > usedWords.Count) return false;
         return true;
     }
    */
 
    public static bool WordPattern(string pattern, string s)
    {

        Dictionary<char, string> dict = new Dictionary<char, string>();

        string[] arr = s.Split(" ");
        if (arr.Length != pattern.Length)
        {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.ContainsKey(pattern[i]))
            {



                if (dict[pattern[i]] != arr[i])
                {
                    return false;
                }
            }
            else
            {

                if (dict.ContainsValue(arr[i]))
                {
                    return false;
                }
                dict.Add(pattern[i], arr[i]);
            }
        }


        return true;
    }

    public static void Main()
    {
        Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
        Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
        Console.WriteLine(WordPattern("aaaa", "dog cat cat dog"));
        Console.WriteLine(WordPattern("abba", "dog dog dog dog"));


    }
}