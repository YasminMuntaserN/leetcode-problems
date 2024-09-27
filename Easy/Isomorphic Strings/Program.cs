public class Solution
{
    /*
     Given two strings s and t, determine if they are isomorphic.
     Two strings s and t are isomorphic if the characters in s can be replaced to get t.
     All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
     */
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary <char ,char> tdic = new Dictionary <char ,char> ();
        Dictionary<char, char> sdic = new Dictionary<char, char>();


        if (t.Length != s.Length) return false;

        for(int i= 0; i < s.Length; i++) 
        {
            if (tdic.ContainsKey(s[i])){
                if (tdic[s[i]] != t[i] ) return false;
            }
            else
            {
                tdic.Add(s[i], t[i]);

            }

            if (sdic.ContainsKey(t[i]))
            {
                if (sdic[t[i]] != s[i]) return false;
            }
            else
            {
                sdic.Add(t[i], s[i]);

            }

        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsIsomorphic("paper", "title"));
        Console.WriteLine(IsIsomorphic("foo", "bar"));
        Console.WriteLine(IsIsomorphic( "egg","add"));

    }
}
