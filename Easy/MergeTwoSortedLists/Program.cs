
// Definition for singly-linked list.
using System.Reflection;

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
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode MergeList =head;

        while (list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                MergeList.next = list1;
                list1 = list1.next;

            }
            else
            {
                MergeList.next = list2;
                list2 = list2.next;
            }
            MergeList = MergeList.next;
        }

        MergeList.next = list1 ?? list2;

        return head.next;
    }
  
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " -> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }

    public static void Main()
    {
        // Create list1: 1 -> 2 -> 4
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

        // Create list2: 1 -> 3 -> 4
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));


        PrintList(MergeTwoLists(list1, list2));
    }
}
