using System.Collections.Generic;
/*
   Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
   Example 1:
   
   Input: nums = [3,0,1]
   Output: 2
   Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
   Example 2:
   
   Input: nums = [0,1]
   Output: 2
   Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
   Example 3:
   
   Input: nums = [9,6,4,2,3,5,7,0,1]
   Output: 8
   Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.
 */
public class Solution
{
    /* // nice Solution :)
        public int MissingNumber(int[] nums) {
        int sum = 0; 
        foreach(int n in nums){
            sum += n;
        }
        return (nums.Length*(nums.Length+1)/2) - sum;
        }

      */
    public static int MissingNumber(int[] nums)
    {
        //Convert the array to a SortedSet
        SortedSet<int> sortedSet = new SortedSet<int>(nums);

        // Iterate from 0 to the expected length of the array 
        for (int i = 0; i <= nums.Length; i++)
        {
            // If the current number is not in the set, it is the missing number
            if (!sortedSet.Contains(i))
            {
                return i;
            }
        }

        return 0; // This line should not be reached because the missing number will always be found in the loop
    }
    
    public static void Main()
        {
           Console.WriteLine( MissingNumber([3, 1, 0]));
           Console.WriteLine(MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));
           Console.WriteLine(MissingNumber([0, 1]));


        }
    }
