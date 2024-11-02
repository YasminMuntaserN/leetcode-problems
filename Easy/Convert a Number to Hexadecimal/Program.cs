/*
     Given a 32-bit integer num, return a string representing its hexadecimal representation. For negative integers, two’s complement method is used.
     All the letters in the answer string should be lowercase characters, and there should not be any leading zeros in the answer except for the zero itself.
     Note: You are not allowed to use any built-in library method to directly solve this problem.
 */
public class Solution
{
    public static string represent(int num)
    {
        Dictionary<int, string> decimalToHex = new Dictionary<int, string>
        {
            { 0, "0" },
            { 1, "1" },
            { 2, "2" },
            { 3, "3" },
            { 4, "4" },
            { 5, "5" },
            { 6, "6" },
            { 7, "7" },
            { 8, "8" },
            { 9, "9" },
            { 10, "a" },
            { 11, "b" },
            { 12, "c" },
            { 13, "d" },
            { 14, "e" },
            { 15, "f" }
        };
        return decimalToHex[num];
    }

    public static string ToHex(int num)
    {
        if (num == 0) return "0";
        // If the number is negative, convert it to unsigned to handle two's complement representation
        uint unsignedNum = (uint)num;

        string rep = "";
        while (unsignedNum > 0)
        {
            int remainder = (int)(unsignedNum % 16);
            rep += represent(remainder);
            unsignedNum = unsignedNum / 16;
        }

        return string.Join("", rep.ToArray().Reverse());
    }

    public static void Main()
    {
        Console.WriteLine(ToHex(26));          
        Console.WriteLine(ToHex(123456789));   
        Console.WriteLine(ToHex(-1));          
        Console.WriteLine(ToHex(-5));          
        Console.WriteLine(ToHex(0));           
    }
}

