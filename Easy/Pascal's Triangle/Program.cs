public class Solution
{
    /*
     Given an integer numRows, return the first numRows of Pascal's triangle.
     In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
     
     Example 1:
     Input: numRows = 5
     Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
     Example 2:
     
     Input: numRows = 1
     Output: [[1]]
 
     */
    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        // Iterate through each row
        for (int i = 0; i < numRows; i++)
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
    public static void Main(string[] args)
    {
        // Call the Generate function with numRows = 5
        int numRows = 5;
        IList<IList<int>> result = Generate(numRows);

        // Print Pascal's Triangle
        foreach (var row in result)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
