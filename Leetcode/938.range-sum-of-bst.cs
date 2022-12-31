/*
 * @lc app=leetcode id=938 lang=csharp
 *
 * [938] Range Sum of BST
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
    public int RangeSumBST(TreeNode root, int low, int high) {
        int result = 0;
        
        var node = root;
        while (node != null)
        {
            if (node.left == null)
            {
                if (node.val > high)
                {
                    break;
                }
                else if (node.val >= low)
                {
                    result += node.val;
                }
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null && prev.right != node)
                {
                    prev = prev.right;
                }
                if (prev.right == null)
                {
                    prev.right = node;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    if (node.val > high)
                    {
                        break;
                    }
                    else if (node.val >= low)
                    {
                        result += node.val;
                    }
                    node = node.right;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

