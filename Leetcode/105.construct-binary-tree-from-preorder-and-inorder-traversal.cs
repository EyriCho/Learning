/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0)
        {
            return null;
        }
        
        int val = preorder[0];
        var node = new TreeNode(val);
        if (preorder.Length == 1)
        {
            return node;
        }
        
        int index = 0;
        while (inorder[index] != val)
        {
            index++;
        }
        
        node.left = BuildTree(preorder[1..(1 + index)], inorder[0..index]);
        node.right = BuildTree(preorder[(1 + index)..], inorder[(index + 1)..]);
        return node;
   }
}
// @lc code=end

