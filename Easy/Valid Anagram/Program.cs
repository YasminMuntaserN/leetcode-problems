public class Solution
{
    /*
     Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     Example 1:
     Input: s = "anagram", t = "nagaram"
     Output: true
     
     Example 2:
     Input: s = "rat", t = "car"
     Output: false
      */
    public static  bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        return string.Equals(new string(s.OrderBy(c => c).ToArray()), new string(t.OrderBy(c => c).ToArray()));

    }

    public static void Main()
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));

    }
}
