public class Program
{
    /*
     A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself. A divisor of an integer x is an integer that can divide x evenly.
     Given an integer n, return true if n is a perfect number, otherwise return false.
     */
    public static bool CheckPerfectNumber(int num)
    {
        if (num <= 1) return false;
        
        var list = Enumerable.Range(1, (int)Math.Sqrt(num)).Where(i => num % i == 0).ToList();
        int sum = list.Sum();
        foreach (var i in list)
            if (i != 1 && i != num / i) sum += num / i;
        return sum == num;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($@" 7 => {CheckPerfectNumber(7)}");
        Console.WriteLine($@" 28 => {CheckPerfectNumber(28)}");
    }
}