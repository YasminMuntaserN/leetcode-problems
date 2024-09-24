using Microsoft.VisualBasic;

public class Solution
{
    /*
     Given a date, return the corresponding day of the week for that date.
     The input is given as three integers representing the day, month and year respectively.
     Return the answer as one of the following values {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.
      */
    static void Main()
    {
        Console.WriteLine(DayOfTheWeek(31, 8, 2019)); // Output: Saturday
        Console.WriteLine(DayOfTheWeek(18, 7, 1999)); // Output: Sunday
        Console.WriteLine(DayOfTheWeek(15, 8, 1993)); // Output: Sunday
    }

    public static string DayOfTheWeek(int day, int month, int year)
    {
        return (new DateTime(year, month, day)).DayOfWeek.ToString();
    }


}
