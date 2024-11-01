/*
 * @lc app=leetcode id=2641 lang=csharp
 *
 * [2641] Cousins in Binary Tree II
 */

// @lc code=start
public class Solution {
    public TreeNode ReplaceValueInTree(TreeNode root) {
        int next = root.val,
            count = 0,
            childVal = 0;
        TreeNode node = null;
        Queue<TreeNode> queue = new (),
            parentQueue = new ();
        queue.Enqueue(root);
        root.val = 0;

        while (queue.Count > 0)
        {
            count = queue.Count;
            next = 0;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                parentQueue.Enqueue(node);

                if (node.left != null)
                {
                    next += node.left.val;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    next += node.right.val;
                    queue.Enqueue(node.right);
                }
            }

            while (parentQueue.Count > 0)
            {
                node = parentQueue.Dequeue();

                childVal = next - (node.left?.val ?? 0) - (node.right?.val ?? 0);
                if (node.left != null)
                {
                    node.left.val = childVal;
                }

                if (node.right != null)
                {
                    node.right.val = childVal;
                }
            }
        }

        return root;
    }
}
// @lc code=end

