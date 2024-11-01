/*
 * @lc app=leetcode id=2583 lang=csharp
 *
 * [2583] Kth Largest Sum in a Binary Tree
 */

// @lc code=start
public class Solution {
    public long KthLargestLevelSum(TreeNode root, int k) {
        PriorityQueue<long, long> maxStack = new (Comparer<long>.Create((a, b) => b.CompareTo(a)));

        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);
        long count = 0L,
            level = 0L;
        TreeNode node = null;
        while (queue.Count > 0)
        {
            count = queue.Count;
            level = 0L;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                level += node.val;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            maxStack.Enqueue(level, level);
        }

        if (maxStack.Count < k)
        {
            return -1;
        }

        while (k-- > 1)
        {
            maxStack.Dequeue();
        }

        return maxStack.Peek();
    }
}
// @lc code=end

