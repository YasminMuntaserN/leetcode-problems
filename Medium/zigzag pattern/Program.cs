using System.Text;

public class Solution
{
    public static string Convert(string s, int numRows)
    {
        // Edge case: If numRows is 1, return the string as is
        if (numRows == 1)
            return s;

        // Initialize the 2D array (char matrix)
        char[][] arr = new char[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            arr[i] = new char[s.Length]; // Initialize columns with the length of the string
        }

        // Variables to track the current row, column, and direction
        int row = 0, col = 0;
        bool goingDown = true;

        // Fill the zigzag array
        for (int i = 0; i < s.Length; i++)
        {
            arr[row][col] = s[i]; // Place the character in the appropriate row

            // Print current placement for debugging
           // Console.WriteLine($"row: {row}, col: {col}, char: {s[i]}");

            // Determine the direction and adjust row/column accordingly
            if (goingDown)
            {
                row++; // Move down
                if (row == numRows) // If we hit the bottom, go up
                {
                    row = numRows - 2; // Move to the second-to-last row
                    col++; // Move to the next column
                    goingDown = false; // Change direction
                }
            }
            else
            {
                row--; // Move up
                col++; // Move to the next column
                if (row == -1) // If we hit the top, go down
                {
                    row = 1; // Move to the second row
                    goingDown = true; // Change direction
                }
            }
        }

        // Collect the result from the zigzag array row by row
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (arr[i][j] != '\0') // Only append non-empty cells
                {
                    result.Append(arr[i][j]);
                }
            }
        }

        return result.ToString();
    }
    public static void Main()
    {
        Convert("PAYPALISHIRING", 3);
    }
}
