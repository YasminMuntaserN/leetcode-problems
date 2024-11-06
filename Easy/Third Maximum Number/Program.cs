/*
        Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

        Example 1:
        Input: nums = [3,2,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2.
        The third distinct maximum is 1.
 */

public class Solution
{
    public static int ThirdMax(int[] nums)
    {
        if(nums.Length ==0) return 0;
        HashSet<int> hashSet = new HashSet<int> (nums);
        SortedSet<int> sortedSet = new SortedSet<int> (hashSet);

        return (sortedSet.Count < 3) ? sortedSet.Last() :sortedSet.Reverse().Skip(2).First();

        /*
        var temp = nums.OrderByDescending(x => x).Distinct().ToList();
        return temp.Count >= 3 ? temp[2] : temp[0];
         */
    }

    public static void Main()
    {
        Console.WriteLine(ThirdMax([3, 2, 1]));
        Console.WriteLine(ThirdMax([1, 2]));
        Console.WriteLine(ThirdMax([2, 2, 3, 1])); 
    }
}
