public class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        if(nums.Contains(target)) return Array.IndexOf(nums, target);


        int loopEnd = nums.Length, loopStart=0;

        //if (nums.Length != 2)
        //{
            if (target < nums[nums.Length / 2])
                loopEnd =(nums.Length / 2)+1;
            else
                loopStart = nums.Length / 2;
        //}

        for(int i = loopStart; i < loopEnd; i++)
        {
            if(target < nums[i]) return i;
        }

        // If target is greater than all elements, return the last index + 1
        // If target is Smaller than all elements, return 0;

        return (target < nums[0])?0: nums.Length;
    }
    public static void Main()
    {
        // Test cases
        int[] nums1 = { 1, 3, 5, 6 };
        Console.WriteLine(SearchInsert(nums1, 5)); // Output: 2 (target is at index 2)
        Console.WriteLine(SearchInsert(nums1, 2)); // Output: 1 (target should be inserted at index 1)
        Console.WriteLine(SearchInsert(nums1, 7)); // Output: 4 (target should be inserted at index 4)
        Console.WriteLine(SearchInsert(nums1, 4)); 
       
        int[] nums2 = { 1, 3, 5 };
        Console.WriteLine(SearchInsert(nums2, 4));
        Console.WriteLine(SearchInsert(nums2, 2));


        int[] nums3 = { 1};
        Console.WriteLine(SearchInsert(nums3, 0));

        int[] nums4 = { 1,3 };
        Console.WriteLine(SearchInsert(nums4, 2));
        Console.WriteLine(SearchInsert(nums4, 0));

    }
}
