/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
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
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        bool IsMirror(TreeNode l, TreeNode r)
        {
            if (l == null && r == null)
            {
                return true;
            }

            if (l?.val != r?.val )
            {
                return false;
            }
            
            return IsMirror(l.left, r. right) && IsMirror(l.right, r.left);
        }

        return IsMirror(root.left, root.right);
    }
}
// @lc code=end

