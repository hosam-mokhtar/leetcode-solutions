Link: https://leetcode.com/problems/sum-of-left-leaves/
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
            public int SumOfLeftLeaves(TreeNode root)
            {
                Queue<TreeNode> q = [];
                q.Enqueue(root);
                int sum = 0;

                while (q.Count > 0)
                {
                    int size = q.Count;

                    for (int i = 0; i < size; i++)
                    {
                        TreeNode node = q.Dequeue();

                        if (node.left != null)
                        {
                            if (node.left.left == null && node.left.right == null)
                                sum += node.left.val;
                            else
                                q.Enqueue(node.left);
                        }
                        if (node.right != null)
                            q.Enqueue(node.right);
                    }
                }

                return sum;
            }
}