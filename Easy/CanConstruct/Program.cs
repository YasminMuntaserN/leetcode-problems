public class Solution
{
    /*
     Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
     Each letter in magazine can only be used once in ransomNote.
     Example 1:
     Input: ransomNote = "a", magazine = "b"
     Output: false
     Example 2:
     
     Input: ransomNote = "aa", magazine = "ab"
     Output: false
     */

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if(ransomNote.Length > magazine.Length)
        {
            return false;
        }

        List<char> charList = new List<char>(magazine.ToCharArray());
       
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (charList.Contains(ransomNote[i])){
                charList.Remove(ransomNote[i]);
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.WriteLine(CanConstruct( "note" , "notebook"));
        Console.WriteLine(CanConstruct("a", "b"));
        Console.WriteLine(CanConstruct("aa", "ab"));

    }
}
