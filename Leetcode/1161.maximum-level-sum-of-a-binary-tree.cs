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
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);
        TreeNode node = null;
        int level = 1,
            maxLevel = 1,
            sum = 0,
            max = int.MinValue,
            count = 0;
        
        while (queue.Count > 0)
        {
            count = queue.Count;
            sum = 0;
            while (count-- > 0)
            {
                node = queue.Dequeue();
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

