/*
 * @lc app=leetcode id=230 lang=csharp
 *
 * [230] Kth Smallest Element in a BST
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
    public int KthSmallest(TreeNode root, int k) {
        int Helper(TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }
                        
            int l = Helper(node.left);
            if (l >= 0)
            {
                return l;
            }
            
            k--;
            if (k == 0)
            {
                return node.val;
            }
            
            return Helper(node.right);
        }
        
        return Helper(root);
    }
}
// @lc code=end

