public class Solution
{
    /*
     A range [a,b] is the set of all integers from a to b (inclusive).
     Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.
     Each range [a,b] in the list should be output as:
     "a->b" if a != b
     "a" if a == b
      */
  
    public static IList<string> SummaryRanges(int[] nums)
    {
        IList<string> list = new List<string>();
        if (nums.Length == 0) return list;  

        string str = nums[0].ToString();  

        for (int i = 1; i < nums.Length; i++)
        {
           
            if (nums[i] != nums[i - 1] + 1)
            {
                
                if (str != nums[i - 1].ToString())
                {
                    str += "->" + nums[i - 1].ToString();  
                }
                list.Add(str); 
                str = nums[i].ToString();  
            }
        }

        // Handle the last range 
        if (str != nums[nums.Length - 1].ToString())
        {
            str += "->" + nums[nums.Length - 1].ToString();
        }
        list.Add(str);

        return list;
    }

    public static void Main()
    {
        int[] nums = new int[] { 0, 1, 2, 4, 5, 7 };
        Console.WriteLine(string.Join(", ", SummaryRanges(nums)));

        int[] nums1 = new int[] { 0, 2, 3, 4, 6, 8, 9};
        Console.WriteLine(string.Join(", ", SummaryRanges(nums1)));

    }
}
