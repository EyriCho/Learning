/*
 * @lc app=leetcode id=450 lang=csharp
 *
 * [450] Delete Node in a BST
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
    public TreeNode DeleteNode(TreeNode root, int key) {
        TreeNode prev = null;
        var node = root;
        while (node != null)
        {
            // not found, keep going
            if (node.val != key)
            {
                prev = node;
                if (node.val > key)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }
            else // found, delete node
            {
                if (node.left == null && node.right == null)
                {
                    if (prev == null)
                        root = null;
                    else if (prev.left == node)
                        prev.left = null;
                    else
                        prev.right = null;
                }
                else if (node.left == null || node.right == null)
                {
                    var child = node.left == null ? node.right : node.left;
                    if (prev == null)
                        root = child;
                    else if (prev.left == node)
                        prev.left = child;
                    else
                        prev.right = child;
                        
                }
                else
                {
                    TreeNode leftParent = null;
                    var left = node.left;
                    while (left.right != null)
                    {
                        leftParent = left;
                        left = left.right;
                    }
                    if (leftParent == null)
                    {
                        left.right = node.right;
                    }
                    else
                    {
                        leftParent.right = left.left;
                        left.left = node.left;
                        left.right = node.right;
                    }
                    if (prev == null)
                        root = left;
                    else if (prev.left == node)
                        prev.left = left;
                    else
                        prev.right = left;
                }
                node = null;
            }
        }
        
        return root;
    }
}
// @lc code=end

