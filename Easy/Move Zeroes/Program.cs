public class Solution
{
    public static void Swap(int i , int j, int[] nums)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    public static void MoveZeroes(int[] nums)
    {
        if(nums.Length == 0 || nums.Length == 1) return;

        int i = 0, j= 0 ;

        while (i < nums.Length)
        {

            if ( nums[i] != 0)
            {
                Swap(i, j, nums);
                j++;

            }
            i++;
        }
    }
    public static void Main()
    {
        int[] arr1 = [0, 1, 0, 3, 12];
        MoveZeroes(arr1);
        Console.WriteLine(string.Join(" , ", arr1));

        int[] arr2 = [0];
        MoveZeroes(arr2);
        Console.WriteLine(string.Join(" , ", arr2));

        int[] arr3 = [1, 0, 2, 0, 3, 0 ];
        MoveZeroes(arr3);
        Console.WriteLine(string.Join(" , ", arr3));

        int[] arr4 = [1, 2, 3];
        MoveZeroes(arr4);
        Console.WriteLine(string.Join(" , ", arr4));

        

    }
}
