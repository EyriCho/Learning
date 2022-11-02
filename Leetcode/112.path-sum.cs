/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null)
        {
            return false;
        }

        var downSum = sum - root.val;
        if (root.left == null && root.right == null)
        {
            return downSum == 0;
        }

        return HasPathSum(root.left, downSum) || 
            HasPathSum(root.right, downSum);
    }
}
// @lc code=end

