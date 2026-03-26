Link: https://leetcode.com/problems/same-tree/
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)   
                return true;
            if ((p != null && q != null && p.val != q.val) || 
                (p == null && q != null) || 
                (p != null && q == null))
                return false;

            Queue<TreeNode> q1 = [];
            Queue<TreeNode> q2 = [];
            q1.Enqueue(p);
            q2.Enqueue(q);

            while (q1.Count > 0)
            {
                int size = q1.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode x = q1.Dequeue();
                    TreeNode y = q2.Dequeue();

                    if (x.left != null && y.left != null)
                    {
                        if (x.left.val == y.left.val)
                        {
                            q1.Enqueue(x.left);
                            q2.Enqueue(y.left);
                        }
                        else
                            return false;
                    }
                    else if (x.left != y.left)
                        return false;

                    if (x.right != null && y.right != null)
                    {
                        if (x.right.val == y.right.val)
                        {
                            q1.Enqueue(x.right);
                            q2.Enqueue(y.right);
                        }
                        else
                            return false;
                    }
                    else if (x.right != y.right)
                        return false;
                }
            }

            return true;
        }
}