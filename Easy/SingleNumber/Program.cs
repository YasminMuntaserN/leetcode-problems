public class Solution
{
    #region
    /*
     Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
     You must implement a solution with a linear runtime complexity and use only constant extra space.
     Example 1:
     
     Input: nums = [2,2,1]
     Output: 1
     Example 2:
     
     Input: nums = [4,1,2,1,2]
     Output: 4
     Example 3:
     
     Input: nums = [1]
     Output: 1
     */
    #endregion
    public static int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (int x in nums)
        {
            /*
             XOR Operation: For each element x in the array nums, XOR it with result.
             If x appears twice, it will cancel out with itself, contributing nothing to the final result.
             The single number, which does not have a pair, will remain as the result.
             this way will give us  a linear runtime complexity (O(n)) and constant extra space (O(1)
          */
            result ^= x;

        }

        return result;
    }
    public static void Main()
    {
        int[] nums1 = { 2, 2, 1 };
        int single1 = SingleNumber(nums1);
        Console.WriteLine(single1); // Output: 1

        int[] nums2 = { 4, 1, 2, 1, 2 };
        int single2 = SingleNumber(nums2);
        Console.WriteLine(single2); // Output: 4
    }
}
