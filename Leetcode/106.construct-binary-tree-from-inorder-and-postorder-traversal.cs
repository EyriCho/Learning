/*
 * @lc app=leetcode id=106 lang=csharp
 *
 * [106] Construct Binary Tree from Inorder and Postorder Traversal
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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return BuildTree(inorder, postorder, 0, inorder.Length - 1, postorder.Length - 1);     
    }

    public TreeNode BuildTree(int[] inorder, int[] postorder,
        int inStart, int inEnd, int postEnd)
    {
        if (postEnd < 0) return null;
        if (inStart > inEnd) return null;
        var node = new TreeNode(postorder[postEnd]);
        var inIndex = Array.IndexOf(inorder, node.val);
        var numCount = inIndex - inEnd;
        node.left = BuildTree(inorder, postorder,
            inStart, inIndex - 1, postEnd + numCount - 1);
        node.right = BuildTree(inorder, postorder,
            inIndex + 1, inEnd, postEnd - 1);
        return node;
    }
}
// @lc code=end

