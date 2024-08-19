// Definition for singly-linked list.
using System.Collections.Specialized;

#region
/*
    Remove Duplicates from Sorted List
    Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
     Return the linked list sorted as well.
 */

#endregion
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public static ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode current = head.next;
        ListNode prev = head;
        List<int> result = [];

        int i = 0;
        while (current != null)
        {
            if (current.val != prev.val) { result.Add(prev.val); i++; }

            current = current.next;
            prev = prev.next;

        }
        result.Add(prev.val);
        return ConvertListToListNode(result);
    }
    private static ListNode ConvertListToListNode(List<int> list)
    {
        if (list.Count == 0) return null;

        ListNode temp = new ListNode(0);
        ListNode current = temp;

        foreach (int value in list)
        {
            current.next = new ListNode(value);
            current = current.next;
        }

        return temp.next;
    }

    static void Main()
    {
        ListNode head1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        Console.WriteLine("Test Case 1: ");
        PrintList(Solution.DeleteDuplicates(head1));

        ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        Console.WriteLine("Test Case 2: ");
        PrintList(Solution.DeleteDuplicates(head2));

        ListNode head3 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1))));
        Console.WriteLine("Test Case 3: ");
        PrintList(Solution.DeleteDuplicates(head3));

        ListNode head4 = null;
        Console.WriteLine("Test Case 4: ");
        PrintList(Solution.DeleteDuplicates(head4));

        ListNode head5 = new ListNode(1);
        Console.WriteLine("Test Case 5: ");
        PrintList(Solution.DeleteDuplicates(head5));

        ListNode head6 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4))))));
        Console.WriteLine("Test Case 6: ");
        PrintList(Solution.DeleteDuplicates(head6));
    }

    static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " -> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }
}
