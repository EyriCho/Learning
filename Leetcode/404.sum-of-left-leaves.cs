/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
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
    public int SumOfLeftLeaves(TreeNode root) {
        var result = 0;
        
        var node = root;
        while (node != null)
        {
            if (node.left == null)
            {
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null && prev.right != node)
                    prev = prev.right;
                if (prev.right == null)
                {
                    if (prev.left == null && node.left == prev)
                        result += prev.val;
                    prev.right = node;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    node = node.right;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

