/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
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
    public bool IsValidBST(TreeNode root) {
        bool IsValid(TreeNode root, int? lower, int? upper)
        {
            if (root == null)
            {
                return true;
            }
            
            if (root.val <= lower || root.val >= upper)
            {
                return false;
            }
            
            return IsValid(root.left, lower, root.val) &&
                IsValid(root.right, root.val, upper);
        }
        return IsValid(root, null, null);
    }
}
// @lc code=end

