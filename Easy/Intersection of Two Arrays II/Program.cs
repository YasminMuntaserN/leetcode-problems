/*
 Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.
 
 */
public class Solution
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (keyValuePairs.ContainsKey(nums1[i]))
            {
                keyValuePairs[nums1[i]]++;
            }
            else
            {
                keyValuePairs.Add(nums1[i], 1);
            }
        }

        for (int j = 0; j < nums2.Length; j++)
        {
            if (keyValuePairs.ContainsKey(nums2[j]) && keyValuePairs[nums2[j]] > 0)
            {
                result.Add(nums2[j]);
                keyValuePairs[nums2[j]]--;
            }

        }
        return result.ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(String.Join(", ", Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }))); 
        Console.WriteLine(String.Join(", ", Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }))); 

    }
}
