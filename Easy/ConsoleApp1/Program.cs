// to understand this question look here (https://youtu.be/g_S5WuasWUE?si=Z-Pt7SGNJoKQfkk_)
//Definition for a binary tree node.
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
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();

        TreeNode currNode = root;

        if (currNode != null)
        {
            // Recursively call InorderTraversal on the left subtree
            // This will traverse all the nodes in the left subtree
            foreach (int r in InorderTraversal(currNode.left))
                result.Add(r);

            // After visiting the left subtree, add the current node's value to the result
            result.Add(currNode.val);

            // Recursively call InorderTraversal on the right subtree
            // This will traverse all the nodes in the right subtree
            foreach (int r in InorderTraversal(currNode.right))
                result.Add(r);
        }

        return result;
    }

    public static void Main()
    {
        // Create the tree [1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9]
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7)));
        root.right = new TreeNode(3, null, new TreeNode(8, null, new TreeNode(9)));

        // Create an instance of the solution and call the InorderTraversal method
        Solution solution = new Solution();
        IList<int> result = solution.InorderTraversal(root);

        // Print the result
        Console.WriteLine("Inorder Traversal Result: ");
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}
