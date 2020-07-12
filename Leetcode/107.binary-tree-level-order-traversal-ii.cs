/*
 * @lc app=leetcode id=107 lang=csharp
 *
 * [107] Binary Tree Level Order Traversal II
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        var level = new List<int>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                result.Add(level);
                if (queue.Count == 0)
                    break;
                else
                {
                    queue.Enqueue(null);
                    level = new List<int>();
                    continue;
                }
            }

            level.Add(node.val);
            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        result.Reverse();
        return result;
    }
}
// @lc code=end

