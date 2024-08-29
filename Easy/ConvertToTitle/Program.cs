public class Solution
{
    public static string ConvertToTitle(int columnNumber)
    {

        if (columnNumber == 0)
        {
            return "";
        }

        columnNumber--; // Adjust for 1-based indexing
        char letter = (char)('A' + columnNumber % 26);
        return ConvertToTitle(columnNumber / 26) + letter;
    }
    static void Main()
    {
        
        Console.WriteLine(ConvertToTitle(53354

            ));
    }
}