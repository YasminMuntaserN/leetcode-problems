/*
Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.
Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].
For example, swapping at indices 0 and 2 in "abcd" results in "cbad".
 */
public class Program {

    public static bool BuddyStrings(string s, string goal) {
        
        if (goal.Length != s.Length) return false;

        if (goal == s)
            return s != string.Join("",new HashSet<char>(s));
     
        var diff =new List<int>();
        for (int i = 0; i< s.Length ; i++)
        {
                if(s[i] !=  goal[i]) diff.Add(i);
        }

        return diff.Count == 2 && s[diff[0]] == goal[diff[1]] && s[diff[1]] == goal[diff[0]];
    }

    public static void Main()
    {
        Console.WriteLine(BuddyStrings("ab", "ba")); // True
        Console.WriteLine(BuddyStrings("ab", "ab")); // False**
        Console.WriteLine(BuddyStrings("aa", "aa")); // True
        Console.WriteLine(BuddyStrings("aaaaaaabc", "aaaaaaacb")); // True
        Console.WriteLine(BuddyStrings("", "aa")); // False

    }
}