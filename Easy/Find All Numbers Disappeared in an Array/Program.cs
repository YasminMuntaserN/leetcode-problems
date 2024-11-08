/*
     Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

        Example 1:
        Input: nums = [4,3,2,7,8,2,3,1]
        Output: [5,6]

        Example 2:
        Input: nums = [1,1]
        Output: [2]
 */
public class Solution
{
    public static List<int> GenerateOrderListFrom1ToN(int n)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }
        return list;
    }

    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> list = GenerateOrderListFrom1ToN(nums.Length);

        HashSet<int> numsSet = new HashSet<int>(nums);

        List<int> result = new List<int>();

        foreach (var num in list)
        {
            if (!numsSet.Contains(num))
            {
                result.Add(num);
            }
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(" , ", FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
        Console.WriteLine(string.Join(" , ", FindDisappearedNumbers(new int[] { 1, 1 })));
    }
}
