public class Solution
{
    /*
     Given a string s, return the number of segments in the string.
     A segment is defined to be a contiguous sequence of non-space characters.
     
     Example 1:
     Input: s = "Hello, my name is John"
     Output: 5
     Explanation: The five segments are ["Hello,", "my", "name", "is", "John"]
     */
    public static int CountSegments(string s)
    {
        if (String.IsNullOrWhiteSpace(s) ) return 0;
        string []arr =s.Split(new char[] { ' ', '\t', '\n' });
        

        return arr.Count(el => !string.IsNullOrWhiteSpace(el));
    }
    public static void Main()
    {
        // Test cases
        Console.WriteLine(CountSegments("Hello, world!")); 
        Console.WriteLine(CountSegments("  Hello    world  "));
        Console.WriteLine(CountSegments("OpenAI"));
        Console.WriteLine(CountSegments("     ")); 
        Console.WriteLine(CountSegments("")); 
        Console.WriteLine(CountSegments("Hello, OpenAI! How's it going?")); 
        Console.WriteLine(CountSegments("Hello,\nOpenAI\tis here!"));
    }
}
