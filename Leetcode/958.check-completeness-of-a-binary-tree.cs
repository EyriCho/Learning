/*
 * @lc app=leetcode id=958 lang=csharp
 *
 * [958] Check Completeness of a Binary Tree
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
    public bool IsCompleteTree(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var foundEnd = false;
            var count = queue.Count;

            while (count-- > 0)
            {
                var node = queue.Dequeue();
                if (node.left == null)
                {
                    foundEnd = true;
                }
                else
                {
                    if (foundEnd)
                    {
                        return false;
                    }
                    queue.Enqueue(node.left);
                }

                if (node.right == null)
                {
                    foundEnd = true;
                }
                else
                {
                    if (foundEnd)
                    {
                        return false;
                    }
                    queue.Enqueue(node.right);
                }
            }

            if (foundEnd)
            {
                return queue.All(n => n.left == null && n.right == null);
            }
        }

        return true;
    }
}
// @lc code=end

