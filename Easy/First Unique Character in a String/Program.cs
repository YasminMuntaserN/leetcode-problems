public class Solution
{
    /*
     Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
        Example 1:
        Input: s = "leetcode"
        Output: 0
        Explanation:
        The character 'l' at index 0 is the first character that does not occur at any other index.

        Example 2:
        Input: s = "loveleetcode"
        Output: 2
     */

    public static int FirstUniqChar(string s)
    {
         for(int i = 0; i < s.Length; i++)
        {

            int j = 0;
            while (j < s.Length)
            {
                if (j == i)
                {
                    j++;
                    continue;
                }

                if (s[i] != s[j])
                {
                    j++;
                }
                else
                {
                    break;
                }
            }
            if (j == s.Length) return i;

        }
         return -1; 
    }

    public static void Main()
    {
        Console.WriteLine(FirstUniqChar("leetcode"));
        Console.WriteLine(FirstUniqChar("loveleetcode"));
        Console.WriteLine(FirstUniqChar("aabb"));


    }
}
