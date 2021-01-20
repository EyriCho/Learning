/*
 * @lc app=leetcode id=1457 lang=csharp
 *
 * [1457] Pseudo-Palindromic Paths in a Binary Tree
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
    public int PseudoPalindromicPaths (TreeNode root) {
        return PseudoPalindromicPaths(root, 0);
    }
    
    private int PseudoPalindromicPaths(TreeNode root, int path)
    {
        path ^= 1 << root.val;
        int result = 0;
        if (root.left == root.right)
        {
            if ((path & path - 1) == 0)
                return 1;
        }
        else
        {
            if (root.left != null)
                result += PseudoPalindromicPaths(root.left, path);
            if (root.right != null)
                result += PseudoPalindromicPaths(root.right, path);
        }
        
        return result;
    }
}
// @lc code=end

