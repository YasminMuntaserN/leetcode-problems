public class Solution
{
    /*
     You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
     Merge nums1 and nums2 into a single array sorted in non-decreasing order.
     The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
      */
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1; // Last valid index in nums1
        int j = n - 1; // Last valid index in nums2
        int k = m + n - 1; // Last index in merged nums1

        // Merge in reverse order
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // If there are remaining elements in nums2, copy them
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }

    public static void Main()
    {
        // Test Case 1
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        int m = 3; // Number of valid elements in nums1
        int n = 3; // Number of valid elements in nums2

        Merge(nums1, m, nums2, n);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1));

        // Test Case 2
        int[] nums1_2 = { 1 };
        int[] nums2_2 = { };
        int m_2 = 1;
        int n_2 = 0;

        Merge(nums1_2, m_2, nums2_2, n_2);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1_2));

        // Test Case 3
        int[] nums1_3 = { 0 };
        int[] nums2_3 = { 1 };
        int m_3 = 0;
        int n_3 = 1;

        Merge(nums1_3, m_3, nums2_3, n_3);
        Console.WriteLine("Merged array: " + string.Join(", ", nums1_3));
    }
}