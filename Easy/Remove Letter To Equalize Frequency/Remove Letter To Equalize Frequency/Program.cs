/*
You are given a 0-indexed string word, consisting of lowercase English letters. You need to select one index and remove the letter at that index
from word so that the frequency of every letter present in word is equal.
Return true if it is possible to remove one letter so that the frequency of all letters in word are equal, and false otherwise.

Note:
The frequency of a letter x is the number of times it occurs in the string.
You must remove exactly one letter and cannot choose to do nothing.

Example 1:
Input: word = "abcc"
Output: true
Explanation: Select index 3 and delete it: word becomes "abc" and each character has a frequency of 1.
 */
public class Program {
      public static bool EqualFrequency(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            var str = word.Remove(i, 1);
            var freq = GetFrequency(str);

          //  Console.WriteLine($"After removing '{word[i]}': {str}: {string.Join(", ", freq.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
            var freqCount = freq.Values.GroupBy(v => v).ToDictionary(g => g.Key, g => g.Count()); 

            if (freqCount.Count == 1)
            {
                return true;
            }
        }
        return false;
     }

     private static Dictionary<char, int> GetFrequency(string word)
     {
         Dictionary<char, int> frequency = new Dictionary<char, int>();
         foreach (char letter in word)
         {
             if (!frequency.ContainsKey(letter))
                 frequency.Add(letter, 1);
             else
                 frequency[letter]++;
         }
         return frequency;
     }
    public static void Main()
    {
        Console.WriteLine(EqualFrequency("abcc")); 
        Console.WriteLine(EqualFrequency("aazz")); 
        Console.WriteLine(EqualFrequency("aaabbbccc")); 
        Console.WriteLine(EqualFrequency("aabbccx")); 
        Console.WriteLine(EqualFrequency("bac")); 
    }
}