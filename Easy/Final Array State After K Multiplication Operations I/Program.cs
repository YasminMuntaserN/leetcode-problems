using System.Linq;

public class Solution
{
    /*
      You are given an integer array nums, an integer k, and an integer multiplier.
      You need to perform k operations on nums. In each operation:
      Find the minimum value x in nums. If there are multiple occurrences of the minimum value, select the one that appears first.
      Replace the selected minimum value x with x * multiplier.
      Return an integer array denoting the final state of nums after performing all k operations.
      
      Example 1:
      
      Input: nums = [2,1,3,5,6], k = 5, multiplier = 2
      
      Output: [8,4,6,5,6]
     */
    public static int[] GetFinalState(int[] nums, int k, int multiplier)
    {
       while(k > 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Min() == nums[i])
                {
                    nums[i] *= multiplier;
                    break;
                }
                Console.WriteLine(string.Join(" ", nums));
            }
           k--;
        }
        return nums;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(" ", GetFinalState([2, 1, 3, 5, 6] ,5,2)));
        Console.WriteLine(string.Join(" ", GetFinalState([1, 2], 3, 4)));
        Console.WriteLine(string.Join(" ", GetFinalState([4, 2, 7, 1, 3], 3, 2)));

    }
}
