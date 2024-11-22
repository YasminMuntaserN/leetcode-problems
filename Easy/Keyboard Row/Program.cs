using System.Collections.Generic;

public class Solution
{
      // the first row consists of the characters "qwertyuiop",
     // the second row consists of the characters "asdfghjkl", and
    // the third row consists of the characters "zxcvbnm".
    public static string[] FindWords(string[] words)
    {
        List<string> result = new  List<string>();
        SortedSet<char> first = new SortedSet<char>("qwertyuiop");
        SortedSet<char> second = new SortedSet<char>("asdfghjkl");
        SortedSet<char> third = new SortedSet<char>("zxcvbnm");

        foreach(string w in words)
        {
            string word =w.ToLower();   

            if (word.All(c=> first.Contains(c))   ||
                word.All(c => second.Contains(c)) ||
                word.All(c => third.Contains(c)))
            {
                result.Add(w);
            }
        }
        return result.ToArray();    
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(" , ", FindWords(["Hello", "Alaska", "Dad", "Peace"])));
        Console.WriteLine(string.Join(" , ", FindWords(["omk"])));
        Console.WriteLine(string.Join(" , ", FindWords(["adsdf", "sfd"])));

    }
}
