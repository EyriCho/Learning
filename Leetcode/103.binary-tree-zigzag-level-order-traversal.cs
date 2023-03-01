/*
 * @lc app=leetcode id=103 lang=csharp
 *
 * [103] Binary Tree Zigzag Level Order Traversal
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        var front = true;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var count = queue.Count;
            var list = new List<int>();
            while (count-- > 0)
            {
                var node = queue.Dequeue();
                if (front)
                {
                    list.Add(node.val);
                }
                else
                {
                    list.Insert(0, node.val);
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            result.Add(list);
            front = !front;
        }

        return result;
    }
}
// @lc code=end

