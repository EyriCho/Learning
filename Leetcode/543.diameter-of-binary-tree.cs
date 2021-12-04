/*
 * @lc app=leetcode id=543 lang=csharp
 *
 * [543] Diameter of Binary Tree
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
    public int DiameterOfBinaryTree(TreeNode root) {
        var diameter = 0;
        
        int Helper(TreeNode node)
        {
            if (node == null)
                return 0;
            
            var l = Helper(node.left);
            var r = Helper(node.right);
            
            diameter = Math.Max(diameter, l + r);
            
            return Math.Max(l, r) + 1;
        }
        
        Helper(root);
        
        return diameter;
    }
}
// @lc code=end

