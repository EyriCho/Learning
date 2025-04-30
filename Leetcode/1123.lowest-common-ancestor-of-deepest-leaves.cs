/*
 * @lc app=leetcode id=1123 lang=csharp
 *
 * [1123] Lowest Common Ancestor of Deepest Leaves
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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        if (root.left == null && root.right == null)
        {
            return root;
        }
        
        (TreeNode, int) CommonAncestor(TreeNode node, int depth)
        {
            if (node.left == null && node.right == null)
            {
                return (node, depth);
            }
            else if (node.left == null)
            {
                return CommonAncestor(node.right, depth + 1);
            }
            else if (node.right == null)
            {
                return CommonAncestor(node.left, depth + 1);
            }

            (TreeNode l, int lDepth) = CommonAncestor(node.left, depth + 1);
            (TreeNode r, int rDepth) = CommonAncestor(node.right, depth + 1);
            if (lDepth > rDepth)
            {
                return (l, lDepth);
            }
            else if (lDepth < rDepth)
            {
                return (r, rDepth);
            }
            else
            {
                return (node, lDepth);
            }
        }

        return CommonAncestor(root, 0).Item1;
    }
}
// @lc code=end

