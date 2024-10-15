
public class Solution
{
  /*  Given a string date representing a Gregorian calendar date formatted as YYYY-MM-DD, return the day number of the year.

      Example 1:
      Input: date = "2019-01-09"
      Output: 9
      Explanation: Given date is the 9th day of the year in 2019.
      
      Example 2:
      Input: date = "2019-02-10"
      Output: 41
  */
   
    #region without Using Built-In Functions
    public static int getDaysInMonth(int Month ,int Year)
    {
        if (Month < 1 || Month > 12)
        {
            return 0;
        }

        List<int> days31 = new List<int>([1,3,5,7,8,10,12 ]);

        return Month == 2 ? (DateTime.IsLeapYear(Year) ? 29 : 28)
                   : days31.Contains(Month) ? 31 : 30;
    }
    public static int DayOfYear(string date)
    {
        int numOfDays = 0;
        //"2019-01-09"
        string[]arr = date.Split("-");
        int year = int.Parse(arr[0]) ,
         Month = int.Parse(arr[1]),
         Day = int.Parse(arr[2]);

        for (int i = 1;i< Month; i++)
        {
            //Console.WriteLine($"{Month} ,{numOfDays}");
            numOfDays += getDaysInMonth(i, year);
        }

        return numOfDays + Day;
    }
    #endregion

  
    #region Using Built-In Functions
    public static int DayOfYear2(string date)
    {
        if (!DateTime.TryParse(date, out DateTime dateObject))
        {
            return -1;
        }

        return dateObject.DayOfYear;
    }
    #endregion
    public static void Main()
    {
       Console.WriteLine( DayOfYear("2019-01-09"));
        Console.WriteLine(DayOfYear("2019-02-10"));

    }
}
