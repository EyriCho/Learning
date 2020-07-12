/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
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
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var node = root;
        while (node != null)
        {
            if (node.left == null)
            {
                result.Add(node.val);
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null && prev.right != node)
                    prev = prev.right;
                if (prev.right == null)
                {
                    prev.right = node;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    result.Add(node.val);
                    node = node.right;
                }
            }
        }
        return result;
    }
}
// @lc code=end

