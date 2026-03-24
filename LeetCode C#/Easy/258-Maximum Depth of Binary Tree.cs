Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
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
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            
            int levels = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.left != null)
                        queue.Enqueue(current.left);
                    if (current.right != null)
                        queue.Enqueue(current.right);
                }

                levels++;
            }

            return levels;
        }
}