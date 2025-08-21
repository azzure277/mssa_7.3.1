namespace mssa_7._3._1
{
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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null && root.val != val)
            {
                root = val < root.val ? root.left : root.right;
            }
            return root;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage:
            // Build a sample BST and search for a value
            TreeNode root = new TreeNode(4,
                new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                new TreeNode(7)
            );

            Solution solution = new Solution();
            TreeNode result = solution.SearchBST(root, 2);

            // Output result (for demonstration)
            if (result != null)
            {
                Console.WriteLine($"Found node with value: {result.val}");
            }
            else
            {
                Console.WriteLine("Node not found.");
            }
        }
    }
}
