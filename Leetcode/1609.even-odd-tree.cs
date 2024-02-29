/*
 * @lc app=leetcode id=1609 lang=csharp
 *
 * [1609] Even Odd Tree
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
    public bool IsEvenOddTree(TreeNode root) {
        bool isOdd = true;
        int prev = 0,
            count = 0;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            prev = isOdd ? 0 : 1_000_001;
            count = queue.Count;
            while (count-- > 0)
            {
                TreeNode node = queue.Dequeue();
                if (isOdd ^ ((node.val & 1) == 1))
                {
                    return false;
                }
                if ((isOdd && node.val <= prev) ||
                    (!isOdd && node.val >= prev))
                {
                    return false;
                }
                prev = node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            isOdd = !isOdd;
        }
        return true;
    }
}
// @lc code=end

