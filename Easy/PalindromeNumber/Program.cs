using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    //Given an integer x, return true if x is a palindrome, and false otherwise.
    public bool IsPalindrome(int x)
    {
        // Negative numbers and numbers ending in 0  are not palindromes
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        // Create two-pointer, one to check the number from the front and the other to check the number from the back and equalize the numbers.
        string Num = x.ToString();
        int head = 0;
        int tail = Num.Length - 1;

        while (head < Num.Length / 2)
        {
            if (Num[head] != Num[tail])
            {
                return false;
            }
            head++;
            tail--;
        }
        return true;
    }

    public static void Main()
    {
        Solution s = new Solution();
        if (s.IsPalindrome(1234321)) Console.WriteLine("True"); else Console.WriteLine("False"); 
    }
}
