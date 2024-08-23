using System.Collections.Generic;

public class Solution
{
    /*Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
      Example 1:
      Input: nums = [1,2,3,1]
      Output: true
      Example 2:
      
      Input: nums = [1,2,3,4]
      Output: false
      Example 3:
      
      Input: nums = [1,1,1,3,3,4,3,2,4,2]
      Output: true
    */

    public static bool ContainsDuplicate(int[] nums)
    {
        //  HashSet<int> seenNumbers = new HashSet<int>();

        //foreach (int num in nums)
        //{
        //    if (seenNumbers.Contains(num))
        //    {
        //        return true;
        //    }
        //    seenNumbers.Add(num);
        //}

        //return false;'

        //collection that automatically removes duplicate elements because it only allows unique values.,
        //When  pass the nums array to the HashSet<int> constructor, the HashSet will store only the unique elements from nums.
        return nums.Length != new HashSet<int>(nums).Count;
    }
    public static void Main(string[] args)
    {
        // Example 1:
        int[] nums1 = { 1, 2, 3, 1 };
        Console.WriteLine(ContainsDuplicate(nums1)); // Expected output: true

        // Example 2:
        int[] nums2 = { 1, 2, 3, 4 };
        Console.WriteLine(ContainsDuplicate(nums2)); // Expected output: false

        // Example 3:
        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine(ContainsDuplicate(nums3)); // Expected output: true

    }
}
