using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    #region
    /*Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
      
      Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
      
      Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
      Return k.*/
    #endregion

    public static bool Contain(int[] nums ,int index , int value)
    {
        // Check if the value exists in nums before the current index
        for (int i = 0; i < index; i++)
        {
            if (nums[i] == value) return true;
        }
        return false;
    }
    public static int RemoveDuplicates(int[] nums)
    {
        int k = 0; // Pointer to track the position of the next unique element

        for (int i = 0; i < nums.Length; i++)
        {
            if (!Contain(nums, i, nums[i]))
            {
                nums[k] = nums[i];
                k++;
            }
        }

        // After k, the remaining elements in nums are not important
        return k; // Return the number of unique elements
    }
    static void Main()
    {
        int[] nums1 = { 1, 1, 2 };
        int k1 = RemoveDuplicates(nums1);
        Console.WriteLine($"Output: {k1}, nums = [{string.Join(",", nums1.Take(k1))},_]");

        int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k2 = RemoveDuplicates(nums2);
        Console.WriteLine($"Output: {k2}, nums = [{string.Join(",", nums2.Take(k2))},_]");

    }
}
