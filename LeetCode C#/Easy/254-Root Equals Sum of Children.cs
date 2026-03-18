Link: https://leetcode.com/problems/root-equals-sum-of-children/
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
        public bool CheckTree(TreeNode root)
        {
            if (root.left.val + root.right.val == root.val)
                return true;
            return false;
        }
}