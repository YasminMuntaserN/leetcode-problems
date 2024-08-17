public class Solution
{
    public static  int MySqrt(int x)
    {
        if (x == 0) return 0;

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
