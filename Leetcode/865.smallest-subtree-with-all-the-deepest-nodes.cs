/*
 * @lc app=leetcode id=865 lang=csharp
 *
 * [865] Smallest Subtree with all the Deepest Nodes
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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        (TreeNode Node, int Level) Helper(TreeNode node)
        {
            if (node == null)
            {
                return (null, 0);
            }

            var l = Helper(node.left);
            var r = Helper(node.right);

            if (l.Level == r.Level)
            {
                return (node, l.Level + 1);
            }
            else if (l.Level > r.Level)
            {
                return (l.Node, l.Level + 1);
            }
            else
            {
                return (r.Node, r.Level + 1);
            }
        }

        return Helper(root).Node;
    }
}
// @lc code=end

