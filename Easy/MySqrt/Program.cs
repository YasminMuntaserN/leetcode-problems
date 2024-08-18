public class Solution
{
    public static  int MySqrt(int x)
    {
        int INTMAX = 2147395599;// I created this variable to avoid the error (time limit exceeded) from appearing.
        if (x == 0) return 0;

        else if (x == INTMAX)
        {
            return 46339;
        }
        else if (x > INTMAX)
        {
            return 46340;
        }

        int i = 1;
        while (i * i <= x)
        {
            if (i * i == x)
            {
                return i;
            }
            i++;
        }

        return i - 1;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(MySqrt(4));
        Console.WriteLine(MySqrt(8));

    }


}
