/*
        Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

        Example 1:
        Input: s = "abab"
        Output: true
        Explanation: It is the substring "ab" twice.

        Example 2:
        Input: s = "aba"
        Output: false
*/
public class Solution
{
    public static bool RepeatedSubstringPattern(string s)
    {
        if (s.Length <= 1) return false;

        string prev = "";  
        int subLength = 0; 

        for (int i = 1; i <= s.Length / 2; i++)
        {
            if (s.Length % i == 0)
            {
                prev = s.Substring(0, i);
                subLength = prev.Length;

                bool isPattern = true;

                for (int j = subLength; j < s.Length; j += subLength)
                {
                    if (s.Substring(j, subLength) != prev)
                    {
                        isPattern = false;
                        break;
                    }
                }

                if (isPattern) return true;
            }
        }

        return false;
    }

    public static void Main()
    {
        Console.WriteLine(RepeatedSubstringPattern("abab"));        
        Console.WriteLine(RepeatedSubstringPattern("aba"));         
        Console.WriteLine(RepeatedSubstringPattern("a"));           
        Console.WriteLine(RepeatedSubstringPattern("abcabcabcabc"));
        Console.WriteLine(RepeatedSubstringPattern("abcdabcd"));    
        Console.WriteLine(RepeatedSubstringPattern("abcdefgh"));    
    }

}
