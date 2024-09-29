using System.Collections.Generic;

public class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        // Sort the array first
        Array.Sort(nums);

        // Iterate through the array
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip duplicate elements to avoid duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    // We found a valid triplet
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Move both pointers and skip duplicates
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
                else if (sum < 0)
                {
                    // Sum is too small, move the left pointer to increase the sum
                    left++;
                }
                else
                {
                    // Sum is too large, move the right pointer to decrease the sum
                    right--;
                }
            }
        }

        return result;
    }


    public static void Main()
    {
        IList<IList<int>> result = ThreeSum([-4, -1, -1, 0, 1, 2]);

        foreach (List<int> i in result)
        {
            Console.WriteLine(string.Join(" , ", i));
        }
    }
}