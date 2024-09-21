public class Solution
{
    public static  bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) // Check outside the loop
            return false;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                int value = map[nums[i]];
                int diff = i - value;
                if (diff <= k)
                {
                    return true;
                }
            }
            // Update the dictionary with the current index of nums[i]
            map[nums[i]] = i;
        }

        return false;
    }
    public static void Main()
    {
        Console.WriteLine(ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3] ,2 ));
    }
}
