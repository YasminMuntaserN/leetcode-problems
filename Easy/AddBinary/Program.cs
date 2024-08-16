public class Solution
{
    public static bool Check(char bitA, char bitB, char reminder)
    {
        if ((bitA == '0' && bitB == '0') ||
            (bitA == '0' && reminder == '0') ||
            (bitB == '0' && reminder == '0'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static  string AddBinary(string a, string b)
    {
        string addResult = "";
        char reminder = '0';
        int p1 = a.Length - 1, p2 = b.Length - 1;

        while (p1 >= 0 || p2 >= 0)
        {
            // Get the current bits from a and b, or '0' if p1 or p2 is out of bounds
            char bitA = (p1 >= 0) ? a[p1] : '0';
            char bitB = (p2 >= 0) ? b[p2] : '0';

            int sum = (bitA - '0') + (bitB - '0') + (reminder - '0');

            if (sum == 0)
            {
                addResult += '0';
                reminder = '0';
            }
            else if (sum == 1)
            {
                addResult += '1';
                reminder = '0';
            }
            else if (sum == 2)
            {
                addResult += '0';
                reminder = '1';
            }
            else if (sum == 3)
            {
                addResult += '1';
                reminder = '1';
            }

            p1--;
            p2--;
        }


        if (reminder == '1')
        {
            addResult += '1';
        }

        return new string(addResult.Reverse().ToArray());
    }

    public static void Main(string[] args)
    {
        // Test cases
       Console.WriteLine( AddBinary("1101", "1011"));  // Expected output: "11000"
        Console.WriteLine(AddBinary("1010", "1011"));  // Expected output: "10101"
        Console.WriteLine(AddBinary("111", "1"));     // Expected output: "1000"
        Console.WriteLine(AddBinary("1111", "1111"));  // Expected output: "11110"
        Console.WriteLine(AddBinary("0", "0"));      // Expected output: "0"
        Console.WriteLine(AddBinary("1", "111"));      // Expected output: "1000"

        Console.ReadLine();  // To keep the console open
    }


}
