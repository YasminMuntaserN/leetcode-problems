public class Solution
{
    /*
      Write a function that reverses a string. The input string is given as an array of characters s.
      
      You must do this by modifying the input array in-place with O(1) extra memory.
      
      Example 1:
      Input: s = ["h","e","l","l","o"]
      Output: ["o","l","l","e","h"]
      Example 2:
      
      Input: s = ["H","a","n","n","a","h"]
      Output: ["h","a","n","n","a","H"]
     */
    public static void ReverseString(char[] s)
    {
        int tail = s.Length - 1;
        int head = 0;

        while (tail > head)
        {
            char temp = s[head];
            s[head] = s[tail];
            s[tail] = temp;
            head++;
            tail--;
        }
    }

    public static void Main(string[] args)
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o' };

        ReverseString(s);

        // Printing the reversed array
        Console.WriteLine(new string(s));  // Output: "olleh"
    }
} 
