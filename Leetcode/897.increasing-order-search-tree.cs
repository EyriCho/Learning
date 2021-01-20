/*
 * @lc app=leetcode id=897 lang=csharp
 *
 * [897] Increasing Order Search Tree
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
    public TreeNode IncreasingBST(TreeNode root) {
        if (root == null)
            return root;
        
        root.right = IncreasingBST(root.right);
        
        if (root.left == null)
            return root;
        else
        {
            var left = IncreasingBST(root.left);
            root.left = null;
            var node = left;
            while (node.right != null)
                node = node.right;
            node.right = root;
            return left;
        }
    }
}
// @lc code=end

