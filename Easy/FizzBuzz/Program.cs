using System.Linq;

public class Solution
{
    /*
    Given an integer n, return a string array answer (1-indexed) where:
    answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    answer[i] == "Fizz" if i is divisible by 3.
    answer[i] == "Buzz" if i is divisible by 5.
    answer[i] == i (as a string) if none of the above conditions are true.
 
     */
    public static IList<string> FizzBuzz(int n)
    {
        IList<string> FB = new List<string>();
        for (int i= 1;i <= n; i++)
        {
            string result = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");

            FB.Add(string.IsNullOrEmpty(result) ? i.ToString() : result);

        }
        return FB;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(" , ", FizzBuzz(5)));
        Console.WriteLine(string.Join(" , ", FizzBuzz(3)));
        Console.WriteLine(string.Join(" , ", FizzBuzz(15)));

    }
}
