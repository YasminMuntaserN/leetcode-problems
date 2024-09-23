public class Solution
{
    /*
     Write a program to count the number of days between two dates.
     The two dates are given as strings, their format is YYYY-MM-DD as shown in the examples.
     
     Example 1:
     Input: date1 = "2019-06-29", date2 = "2019-06-30"
     Output: 1
     
     Example 2:
     Input: date1 = "2020-01-15", date2 = "2019-12-31"
     Output: 15
      */
    public static int DaysBetweenDates(string date1, string date2)
    {
        // Try parsing the dates
        if (!DateTime.TryParse(date1, out DateTime firstDate) || !DateTime.TryParse(date2, out DateTime secondDate))
        {
            throw new ArgumentException("One or both date strings are in an invalid format.");
        }

        // Calculate the difference in days
        TimeSpan difference = secondDate - firstDate;

        // Return the absolute value of the difference in days
        return (int)Math.Abs(difference.TotalDays);
    }

    private static void Main()
    {
        Console.WriteLine(DaysBetweenDates("2019-06-29", "2019-06-30"));

    }
}
