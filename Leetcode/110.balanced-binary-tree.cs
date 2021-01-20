/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 */

// @lc code=start
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
    public bool IsBalanced(TreeNode root) {
        return Helper(root).Item1;
    }
    
    private (bool, int) Helper(TreeNode root)
    {
        if (root == null)
            return (true, 0);
        
        var (l, lLevel) = Helper(root.left);
        if (!l)
            return (false, 0);
        var (r, rLevel) = Helper(root.right);
        if (!r)
            return (false, 0);
        
        var diff = Math.Abs(lLevel - rLevel);
        var level = Math.Max(lLevel, rLevel) + 1;
        
        return (diff < 2, level);
    }
}
// @lc code=end

