/*
 * @lc app=leetcode id=563 lang=csharp
 *
 * [563] Binary Tree Tilt
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
    int result;
    public int FindTilt(TreeNode root) {
        result = 0;
        PostOrderSum(root);
        return result;
    }
    
    private int PostOrderSum(TreeNode root)
    {
        if (root == null)
            return 0;
        
        var left = PostOrderSum(root.left);
        var right = PostOrderSum(root.right);
        
        result += Math.Abs(left - right);
        
        return left + right + root.val;
    }
}
// @lc code=end

