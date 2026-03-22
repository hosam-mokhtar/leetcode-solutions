Link: https://leetcode.com/problems/univalued-binary-tree/
Language: C#







/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
        public bool IsUnivalTree(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int value = root.val;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.left != null)
                    {
                        if (current.left.val != value)
                            return false;
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        if (current.right.val != value)
                            return false;
                        queue.Enqueue(current.right);
                    }
                }
            }

            return true;
        }
}