public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;  // Pointer for the position of the next element that is not equal to val

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

    static void Main()
    {
        int[] nums1 = { 3, 2, 2, 3 };
        int k1 = RemoveElement(nums1,3);
        Console.WriteLine($"Output: {k1}, nums = [{string.Join("," , nums1)}");

        int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int k2 = RemoveElement(nums2 ,2);
        Console.WriteLine($"Output: {k2},  nums = [{string.Join(",", nums2)}");

    }
}