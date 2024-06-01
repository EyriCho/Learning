/*
 * @lc app=leetcode id=129 lang=csharp
 *
 * [129] Sum Root to Leaf Numbers
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
    public int SumNumbers(TreeNode root) {
        int result = 0;
        TreeNode node = null;
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            node = queue.Dequeue();

            if (node.left == null && node.right == null)
            {
                result += node.val;
            }
            else
            {
                if (node.left != null)
                {
                    node.left.val = node.val * 10 + node.left.val;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    node.right.val = node.val * 10 + node.right.val;
                    queue.Enqueue(node.right);
                }
            }
        }

        return result;
    }
}
// @lc code=end

