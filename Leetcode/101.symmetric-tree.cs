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
        if (root == null) return true;

        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((root.left, root.right));
        while (stack.Any())
        {
            var (l, r) = stack.Pop();
            if (l == null || r == null)
            {
                if (l != null || r != null)
                    return false;
            }
            else
            {
                if (l.val != r.val) return false;
                stack.Push((l.left, r.right));
                stack.Push((l.right, r.left));
            }
        }

        return true;
    }
}
// @lc code=end

