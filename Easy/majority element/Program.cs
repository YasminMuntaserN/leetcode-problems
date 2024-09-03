using System.Collections;
using System.Collections.Generic;

public class Solution
{
    /*
        Given an array nums of size n, return the majority element.
        The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
        Input: nums = [3,2,3]
        Output: 3
        Example 2:

        Input: nums = [2,2,1,1,1,2,2]
        Output: 2
     */

    public static int MajorityElement(int[] nums)
    {
        // IEnumerable<int> arrangedNum = nums.OrderBy(i => i);
        //int prevCount = 0 , currentCount =0 , result = 0;
        // foreach (int num in arrangedNum)
        //{
        //    currentCount = arrangedNum.Count(i => i == num);
        //   if (currentCount > prevCount)
        //    {
        //        prevCount = currentCount;
        //        result = num;
        //    }
        //}
        //return result;

        // Sort the array
        Array.Sort(nums);

        // The majority element must be at the middle index
        return nums[nums.Length / 2];
    }

    public static void Main()
    {
        Console.WriteLine("MajorityElement " + MajorityElement([3, 2, 3]));
        Console.WriteLine("MajorityElement " + MajorityElement([2, 2, 1, 1, 1, 2, 2]));
        Console.WriteLine("MajorityElement " + MajorityElement([12, 22, 12, 11, 11, 22, 12]));
        Console.WriteLine("MajorityElement " + MajorityElement([1]));




    }
}
