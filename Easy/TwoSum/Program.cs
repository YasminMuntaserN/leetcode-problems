using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int remaining = target - nums[i];
                if (numIndices.ContainsKey(remaining))
                {
                    return new int[] { numIndices[remaining], i };
                }
                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices[nums[i]] = i;
                }
            }
            return new int[] { 0, 0 };
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSumMethod(nums, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
            Console.ReadKey();
        }
    }
}
