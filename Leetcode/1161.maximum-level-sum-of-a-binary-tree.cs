/*
 * @lc app=leetcode id=1161 lang=csharp
 *
 * [1161] Maximum Level Sum of a Binary Tree
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
    public int MaxLevelSum(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int max = int.MinValue,
            level = 1,
            maxLevel = 1;
        while (queue.Count > 0)
        {
            var c = queue.Count;
            var sum = 0;
            while (c-- > 0)
            {
                var node = queue.Dequeue();
                sum += node.val;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            if (sum > max)
            {
                max = sum;
                maxLevel = level;
            }
            level++;
        }
        return maxLevel;
    }
}
// @lc code=end

