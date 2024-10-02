public class Solution
{
    /*
     In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.
     Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographically in this alien language.
      Example 1:
      
      Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
      Output: true
      Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
     */
   
    public static bool IsAlienSorted(string[] words, string order)
    {
        // Compare each consecutive pair of words
        for (int j = 0; j < words.Length - 1; j++)
        {
            string word1 = words[j];
            string word2 = words[j + 1];

            // Compare characters of both words
            for (int w = 0; w < Math.Min(word1.Length, word2.Length); w++)
            {
                char firstLetter = word1[w];
                char secondLetter = word2[w];

                // If characters are different, compare their order in the alien dictionary
                if (firstLetter != secondLetter)
                {
                    if (order.IndexOf(firstLetter) > order.IndexOf(secondLetter))
                    {
                        return false;
                    }
                    // If the characters are in correct order, no need to compare further for this pair
                    break;
                }
            }

            // If one word is a prefix of the other, the shorter one should come first
            if (word1.Length > word2.Length && word1.StartsWith(word2))
            {
                return false;
            }
        }

        // If no violations are found, return true
        return true;
    }
    public static void Main()
    {
        Console.WriteLine(IsAlienSorted(["hello", "leetcode"], "hlabcdefgijkmnopqrstuvwxyz"));
        Console.WriteLine(IsAlienSorted(["word", "world", "row"], "worldabcefghijkmnpqstuvxyz"));
        Console.WriteLine(IsAlienSorted(["apple", "app"],  "abcdefghijklmnopqrstuvwxyz"));
        Console.WriteLine(IsAlienSorted([ "app" , "apple"], "abcdefghijklmnopqrstuvwxyz"));



    }
}
