/*
  Given two integer arrays nums1 and nums2, return an array of their intersection
  Each element in the result must be unique and you may return the result in any order.
        Example 1:
        Input: nums1 = [1,2,2,1], nums2 = [2,2]
        Output: [2]

        Example 2:
        Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        Output: [9,4]
        Explanation: [4,9] is also accepted.
  */

public class Solution
{
    #region without built in function 
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        HashSet<int> list1 = new HashSet<int>(nums1);
        HashSet<int> list2 = new HashSet<int>(nums2);

        foreach (int i in list1)
        {
            if (list2.Contains(i))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
    #endregion

    #region with built in function 
  /*  public static int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }
  */
    #endregion

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
        Console.WriteLine(string.Join(", ", Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
    }
}