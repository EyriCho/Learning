/*
 * @lc app=leetcode id=783 lang=csharp
 *
 * [783] Minimum Distance Between BST Nodes
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
    public int MinDiffInBST(TreeNode root) {
        TreeNode prev = null;
        var diff = int.MaxValue;

        void Travel(TreeNode node)
        {
            if (node.left != null)
            {
                Travel(node.left);
            }

            if (prev != null)
            {
                diff = Math.Min(node.val - prev.val, diff);
            }

            prev = node;

            if (node.right != null)
            {
                Travel(node.right);
            }
        }
        Travel(root);

        return diff;
    }
}
// @lc code=end

