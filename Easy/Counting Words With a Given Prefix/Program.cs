public class Solution
{
    /*
     You are given an array of strings words and a string pref.
     Return the number of strings in words that contain pref as a prefix.
     A prefix of a string s is any leading contiguous substring of s.
     
     Example 1:
     
     Input: words = ["pay","attention","practice","attend"], pref = "at"
     Output: 2
     Explanation: The 2 strings that contain "at" as a prefix are: "attention" and "attend".
     Example 2:
     
     Input: words = ["leetcode","win","loops","success"], pref = "code"
     Output: 0
     Explanation: There are no strings that contain "code" as a prefix.
     */
    public static int PrefixCount(string[] words, string pref)
    {
        return words.Count(word => word.StartsWith(pref));
    }
   
    /*
    public static int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach (var word in words)
        {
            if (word.StartsWith(pref))
                count++;
        }
        return count;
    }
    */

    public static void Main()
    {
        Console.WriteLine($" num : {PrefixCount(["pay", "attention", "practice", "attend"], "at")}");
        Console.WriteLine($" num : {PrefixCount(["leetcode", "win", "loops", "success"], "code")}");

    }
}
