/*
 * @lc app=leetcode id=1379 lang=csharp
 *
 * [1379] Find a Corresponding Node of a Binary Tree in a Clone of That Tree
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
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (original == null)
            return null;
        if (original == target)
            return cloned;
        
        var left = GetTargetCopy(original.left, cloned.left, target);
        if (left != null)
            return left;
        else
            return GetTargetCopy(original.right, cloned.right, target);
    }
}
// @lc code=end

