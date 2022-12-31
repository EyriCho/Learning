/*
 * @lc app=leetcode id=124 lang=csharp
 *
 * [124] Binary Tree Maximum Path Sum
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
    public int MaxPathSum(TreeNode root) {
        var result = int.MinValue;

        int Travel(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Math.Max(0, Travel(node.left)),
                right = Math.Max(0, Travel(node.right));

            result = Math.Max(result, left + right + node.val);
            
            return node.val + Math.Max(left, right);
        }

        Travel(root);
        return result;
    }
}
// @lc code=end

