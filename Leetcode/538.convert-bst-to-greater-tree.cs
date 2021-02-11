/*
 * @lc app=leetcode id=538 lang=csharp
 *
 * [538] Convert BST to Greater Tree
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
    public TreeNode ConvertBST(TreeNode root) {
         var node = root;
        var sum = 0;
        while (node != null)
        {
            if (node.right == null)
            {
                sum += node.val;
                node.val = sum;
                node = node.left;
            }
            else
            {
                var prev = node.right;
                while (prev.left != null && prev.left != node)
                    prev = prev.left;
                if (prev.left == null)
                {
                    prev.left = node;
                    node = node.right;
                }
                else
                {
                    sum += node.val;
                    node.val = sum;
                    prev.left = null;
                    node = node.left;
                }
            }
        }
        
        return root;
    }
}
// @lc code=end

