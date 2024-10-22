public class Solution
{
    private static Dictionary<char, int> GetKeyValuePairs(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic.Add(c, 1);
            }
        }
        return dic;
    }
    public static int LongestPalindrome(string s)
    {
        int res = 0;
        int CountOfsOnes=0;
        Dictionary<char, int> dic = GetKeyValuePairs(s);

        foreach (KeyValuePair<char, int> kvp in dic)
        {
            if(kvp.Value % 2 != 0)
            {
                res += (kvp.Value -1);
                CountOfsOnes++;
            }
            else
            {
                if(kvp.Value== 1)
                {
                    CountOfsOnes++;
                }
                else
                {
                    res += kvp.Value;
                }
            }
        }
        return res + (CountOfsOnes >0 ? 1:0);
    }

    public static void Main()
    {

         Console.WriteLine( LongestPalindrome("abccccdddeeeff"));
         Console.WriteLine(LongestPalindrome("abccccdd"));
         Console.WriteLine(LongestPalindrome("a"));


    }
}
