public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    /*
     Given the roots of two binary trees p and q, write a function to check if they are the same or not.
     Two binary trees are considered the same if they are structurally identical,
      and the nodes have the same value.
     */
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true; // if the two Trees are empty then they are the same

        if (p == null || q == null) return false;//if one of this two Trees is empty then they are not same

        if (p.val != q.val) return false; //If the values of the current nodes are different, the trees are not the same

        return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
    }
    public static void Main(string[] args)
    {
        // Test Case 1
        TreeNode p1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        TreeNode q1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Console.WriteLine(IsSameTree(p1, q1)); // Expected Output: True

        // Test Case 2
        TreeNode p2 = new TreeNode(1, new TreeNode(2), null);
        TreeNode q2 = new TreeNode(1, null, new TreeNode(2));
        Console.WriteLine(IsSameTree(p2, q2)); // Expected Output: False

        // Test Case 3
        TreeNode p3 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
        TreeNode q3 = new TreeNode(1, new TreeNode(1), new TreeNode(2));
        Console.WriteLine(IsSameTree(p3, q3)); // Expected Output: False

        // Test Case 4 (Edge Case)
        TreeNode p4 = null;
        TreeNode q4 = null;
        Console.WriteLine(IsSameTree(p4, q4)); // Expected Output: True

        // Test Case 5
        TreeNode p5 = new TreeNode(1);
        TreeNode q5 = new TreeNode(1);
        Console.WriteLine(IsSameTree(p5, q5)); // Expected Output: True
    }
}