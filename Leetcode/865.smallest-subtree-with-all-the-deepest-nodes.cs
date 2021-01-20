/*
 * @lc app=leetcode id=865 lang=csharp
 *
 * [865] Smallest Subtree with all the Deepest Nodes
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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        SubtreeWithAllDeepest(root, 0);
        return result;
    }
    
    int level;
    TreeNode result;
    
    private int SubtreeWithAllDeepest(TreeNode node, int depth)
    {
        level = Math.Max(level, depth);
        if (node == null)
            return depth;
        
        int l = SubtreeWithAllDeepest(node.left, depth + 1),
            r = SubtreeWithAllDeepest(node.right, depth + 1);
        
        if (l == r && l == level)
            result = node;
        
        return Math.Max(l, r);
    }
}
// @lc code=end

