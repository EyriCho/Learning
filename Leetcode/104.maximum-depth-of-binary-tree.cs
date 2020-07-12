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
        if (root == null) return 0;

        var result = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                result++;
                if (queue.Count == 0)
                    break;
                else
                {
                    queue.Enqueue(null);
                    continue;
                }
            }

            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return result;
    }
}
// @lc code=end

