public class Solution
{
    /*
     Roman numerals are formed by appending the conversions of decimal place values from highest to lowest. Converting a decimal place value into a Roman numeral has the following rules:
     If the value does not start with 4 or 9, select the symbol of the maximal value that can be subtracted from the input, append that symbol to the result, subtract its value, and convert the remainder to a Roman numeral.
     If the value starts with 4 or 9 use the subtractive form representing one symbol subtracted from the following symbol, for example, 4 is 1 (I) less than 5 (V): IV and 9 is 1 (I) less than 10 (X): IX. Only the following subtractive forms are used: 4 (IV), 9 (IX), 40 (XL), 90 (XC), 400 (CD) and 900 (CM).
     Only powers of 10 (I, X, C, M) can be appended consecutively at most 3 times to represent multiples of 10. You cannot append 5 (V), 50 (L), or 500 (D) multiple times. If you need to append a symbol 4 times use the subtractive form.
     */
    public static string IntToRoman(int num)
    {
        string s = "";
        // List of Roman numeral mappings
        List<KeyValuePair<string, int>> dic = new List<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int>("M", 1000),
            new KeyValuePair<string, int>("CM", 900),
            new KeyValuePair<string, int>("D", 500),
            new KeyValuePair<string, int>("CD", 400),
            new KeyValuePair<string, int>("C", 100),
            new KeyValuePair<string, int>("XC", 90),
            new KeyValuePair<string, int>("L", 50),
            new KeyValuePair<string, int>("XL", 40),
            new KeyValuePair<string, int>("X", 10),
            new KeyValuePair<string, int>("IX", 9),
            new KeyValuePair<string, int>("V", 5),
            new KeyValuePair<string, int>("IV", 4),
            new KeyValuePair<string, int>("I", 1)
        };

        // Convert the integer to Roman numeral
        foreach (var pair in dic)
        {
            while (num >= pair.Value)
            {
                s += pair.Key;
               // Console.WriteLine($"{shortchat} , {num},{pair.Value}");
                num -= pair.Value;
            }
        }

        return s;
    }

    public static void Main()
    {
       Console.WriteLine( IntToRoman(58));
        Console.WriteLine(IntToRoman(1994));
        Console.WriteLine(IntToRoman(3749));

    }
}
