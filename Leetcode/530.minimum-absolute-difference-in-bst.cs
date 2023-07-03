/*
 * @lc app=leetcode id=530 lang=csharp
 *
 * [530] Minimum Absolute Difference in BST
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
    public int GetMinimumDifference(TreeNode root) {
        var result = int.MaxValue;
        int prev = -100_000;

        void Inorder(TreeNode node)
        {
            if (node.left != null)
            {
                Inorder(node.left);
            }
            result = Math.Min(result, node.val - prev);
            prev = node.val;
            if (node.right != null)
            {
                Inorder(node.right);
            }
        }

        Inorder(root);
        
        return result;
    }
}
// @lc code=end

