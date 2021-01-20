/*
 * @lc app=leetcode id=337 lang=csharp
 *
 * [337] House Robber III
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
    public int Rob(TreeNode root) {
        var result = Robbed(root);
        return Math.Max(result[0], result[1]);
    }
    
    private int[] Robbed(TreeNode root)
    {
        if (root == null)
            return new int[2];
        
        var left = Robbed(root.left);
        var right = Robbed(root.right);
        
        return new int[] {
            Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]),
            root.val + left[0] + right[0]
        };
    }
}
// @lc code=end

