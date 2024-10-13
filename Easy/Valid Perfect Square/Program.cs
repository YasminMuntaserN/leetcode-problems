public class Solution
{
    /*
     A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.
     You must not use any built-in library function, such as sqrt.
     
     Example 1:
     Input: num = 16
     Output: true
     Explanation: We return true because 4 * 4 = 16 and 4 is an integer.
     
     Example 2:
     Input: num = 14
     Output: false
     Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
     */
    public static bool IsPerfectSquare(int num)
    {
        if (num == 1) return true;
        for(int i =1; i <= num / i; i++)
        {
            if (num == (i*i)) return true;
           // Console.WriteLine($"{num} , {i} , {(i*i)}");
        }
        return false;
    }
    public static void Main()
    {
        Console.WriteLine(IsPerfectSquare(16));
        Console.WriteLine(IsPerfectSquare(14));

    }
}

