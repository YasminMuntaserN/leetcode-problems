public class Solution
{
    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[] result = new int[nums1.Length];
        Array.Fill(result, -1);
        for (int i = 0; i < nums1.Length; i++)
        {
            int index =Array.IndexOf(nums2, nums1[i]);
            for (int j = index + 1; j < nums2.Length; j++)
            {
                if (nums1[i] < nums2[j])
                {
                    result[i] = nums2[j];
                    break;
                }
            }
        }
        return result;
    }

    public static void Main()
    {
        int[] nums1_1 = new int[] { 2, 5 };
        int[] nums2_1 = new int[] { 2, 3, 5, 6 };
        Console.WriteLine("Test Case 1: " + string.Join(" , ", NextGreaterElement(nums1_1, nums2_1)));

        int[] nums1_2 = new int[] { 1, 4, 6 };
        int[] nums2_2 = new int[] { 2, 1, 5, 4, 6, 3 };
        Console.WriteLine("Test Case 2: " + string.Join(" , ", NextGreaterElement(nums1_2, nums2_2)));

        int[] nums1_3 = new int[] { 2, 3, 1 };
        int[] nums2_3 = new int[] { 1, 2, 3 };
        Console.WriteLine("Test Case 3: " + string.Join(" , ", NextGreaterElement(nums1_3, nums2_3)));

        
    }
}
