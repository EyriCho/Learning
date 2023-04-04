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
        TreeNode Build(int inStart, int inEnd, int postEnd)
        {
            if (postEnd < 0)
            {
                return null;
            }
            if (inStart > inEnd)
            {
                return null;
            }
            var node = new TreeNode(postorder[postEnd]);
            var inIndex = Array.IndexOf(inorder, node.val);
            var numCount = inIndex - inEnd;
            node.left = Build(inStart, inIndex - 1, postEnd + numCount - 1);
            node.right = Build(inIndex + 1, inEnd, postEnd - 1);
            return node;
        };
        
        return Build(0, inorder.Length - 1, postorder.Length - 1);
    }
}
// @lc code=end

