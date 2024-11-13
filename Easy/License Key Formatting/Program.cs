using System.Text;

public class Solution
{
    public static string LicenseKeyFormatting(string s, int k)
    {
        string Str = s.Replace("-", "").ToUpper();

        StringBuilder result = new StringBuilder();

        int count = 0;
        for (int i = Str.Length - 1; i >= 0; i--)
        {
            result.Append(Str[i]);
            count++;

            if (count == k && i != 0)
            {
                result.Append("-");
                count = 0;
            }
        }

        return new string(result.ToString().Reverse().ToArray());
    }

    public static void Main()
    {
        Console.WriteLine(LicenseKeyFormatting("5F3Z-2e-9-w", 4)); 
        Console.WriteLine(LicenseKeyFormatting("2-5g-3-J", 2));   
    }
}