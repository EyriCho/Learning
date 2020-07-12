/*
 * @lc app=leetcode id=145 lang=csharp
 *
 * [145] Binary Tree Postorder Traversal
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
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        var dump = new TreeNode(0)
        {
            left = root,
        };
        var node = dump;
        while (node != null)
        {
            if (node.left == null)
            {
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
                    ReverseRightNode(node.left, result);
                    node = node.right;
                }
            }
        }
        return result;
     }

     public void ReverseRightNode(TreeNode node, IList<int> list)
     {
         if (node.right == null)
        {
            list.Add(node.val);
            return ;
        }

        TreeNode next = null, prev = null;
        while (node != null)
        {
            next = node.right;
            node.right = prev;
            prev = node;
            node = next;
        }

        node = prev;
        prev = null;
        while (node != null)
        {
            next = node.right;
            node.right = prev;
            list.Add(node.val);
            prev = node;
            node = next;
        }
     }
}
// @lc code=end

