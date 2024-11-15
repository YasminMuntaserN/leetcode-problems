public class Solution
{
    /*
     Given a binary array nums, return the maximum number of consecutive 1's in the array.
            Example 1:

            Input: nums = [1,1,0,1,1,1]
            Output: 3
            Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
     */
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0; 
        int count = 0;   

        foreach (int x in nums)
        {
            if (x == 1)
            {
                count++;
                maxCount = Math.Max(maxCount, count); 
            }
            else
            {
                count = 0; 
            }
        }

        return maxCount;
    }
    public static void Main()
    {
        Console.WriteLine(FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
        Console.WriteLine(FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]));

    }

}