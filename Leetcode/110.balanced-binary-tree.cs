/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
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
    public bool IsBalanced(TreeNode root) {
        (bool, int) Balanced(TreeNode node)
        {
            if (node == null)
            {
                return (true, 0);
            }

            (bool balanced, int level) left = Balanced(node.left),
                right = Balanced(node.right);
            
            if (!left.balanced || !right.balanced)
            {
                return (false, 0);
            }

            int max = Math.Max(left.level, right.level);
            if (max - left.level > 1 ||
                max - right.level > 1)
            {
                return (false, 0);
            }

            return (true, max + 1);
        }

        return Balanced(root).Item1;
    }
}
// @lc code=end

