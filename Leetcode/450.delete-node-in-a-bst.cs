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
        if (root == null)
            return null;
        
        if (root.val == key)
        {
            if (root.left == null)
                return root.right;
            else
            {
                var node = root.left;
                while (node.right != null)
                    node = node.right;
                node.right = root.right;
                return root.left;
            }
        }
        else if (root.val < key)
            root.right = DeleteNode(root.right, key);
        else
            root.left = DeleteNode(root.left, key);
        
        return root;
    }
}
// @lc code=end

