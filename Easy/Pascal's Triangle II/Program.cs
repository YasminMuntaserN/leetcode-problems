using System.Linq;

public class Solution
{
    /*
     Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
     In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    Example 1:
    Input: rowIndex = 3
    Output: [1,3,3,1]
    Example 2:
    
    Input: rowIndex = 0
    Output: [1]
    Example 3:
    
    Input: rowIndex = 1
    Output: [1,1]
 
      */

    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        // Iterate through each row
        for (int i = 0; i < numRows; i++)  // Corrected loop condition
        {
            // Create a new list for the current row
            List<int> row = new List<int>();

            // Iterate through each element in the row
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    // The first and last element of each row is always 1
                    row.Add(1);
                }
                else
                {
                    // Other elements are the sum of the two elements above
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }
            }

            // Add the current row to the triangle
            triangle.Add(row);
        }

        return triangle;
    }

    public static IList<int> GetSpecificRow(IList<IList<int>> triangle, int rowIndex)
    {
        // Access the specific row by index
        return triangle[rowIndex];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ", GetSpecificRow(Generate(4), 3)));  // Output: [1, 3, 3, 1]
        Console.WriteLine(string.Join(" ", GetSpecificRow(Generate(1), 0)));  // Output: [1]
        Console.WriteLine(string.Join(" ", GetSpecificRow(Generate(2), 1)));  // Output: [1, 1]
    }

}

