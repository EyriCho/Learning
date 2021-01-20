/*
 * @lc app=leetcode id=1026 lang=csharp
 *
 * [1026] Maximum Difference Between Node and Ancestor
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
    public int MaxAncestorDiff(TreeNode root) {
        result = 0;
        MaxAncestorDiff(root, root.val, root.val);
        return result;
    }
    
    private void MaxAncestorDiff(TreeNode root, int min, int max)
    {
        if (root == null)
            return;
        
        if (root.val > max)
        {
            max = root.val;
            result = Math.Max(result, max - min);
        }
        else if (root.val < min)
        {
            min = root.val;
            result = Math.Max(result, max - min);
        }
            
        MaxAncestorDiff(root.left, min, max);
        MaxAncestorDiff(root.right, min, max);
    }
}
// @lc code=end

