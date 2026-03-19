Link: https://leetcode.com/problems/search-in-a-binary-search-tree/
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
public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val)
                return root;
            root = root.val < val ? root.right : root.left;
        }

        return null;
    }
}