
using System;
using System.Timers;

public class Program
{
    public static void Main()
    {
        // SelectionSort();
        InsertionSort();
    }

    public static void SelectionSort()
    {
        List<int> list = new List<int>([64, 34, 25, 12, 22, 11, 90]);

        Console.WriteLine($"List before sorting : {string.Join(" , ", list)} ");
        for (int i = 0; i < list.Count - 1; i++)
        {
            int MaxIndex = list.IndexOf(list.Skip(i + 1).Max());

            if (list[i] < list[MaxIndex])
            {
                (list[i], list[MaxIndex]) = (list[MaxIndex], list[i]);
            }
        }
        Console.WriteLine($"List After sorting : {string.Join(" , ", list)} ");
    }
    public static void InsertionSort()
    {
        List<int> list = new List<int>([64, 34, 25, 12, 22, 11, 90]);

        Console.WriteLine($"List before sorting : {string.Join(" , ", list)} ");
        for (int i = 1; i < list.Count - 1; i++)
        {
            int index = i;
            while (index > 0)
            {
                
                int MaxIndex = list.IndexOf(list.Take(index + 1).Max());

                if (list[index] < list[MaxIndex])
                {
                    (list[index], list[MaxIndex]) = (list[MaxIndex], list[index]);
                }
                index --;
            }
        }
        Console.WriteLine($"List After sorting : {string.Join(" , ", list)} ");
    }
}