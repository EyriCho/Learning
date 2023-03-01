/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
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
    public int MaxDepth(TreeNode root) {
        int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(Depth(node.left), Depth(node.right)) + 1;
        }

        return Depth(root);
    }
}
// @lc code=end

