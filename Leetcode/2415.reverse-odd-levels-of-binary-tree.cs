/*
 * @lc app=leetcode id=2415 lang=csharp
 *
 * [2415] Reverse Odd Levels of Binary Tree
 */

// @lc code=start
public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root.left == null)
        {
            return root;
        }

        TreeNode left = null,
            right = null;

        Queue<(TreeNode, TreeNode)> queue = new ();
        queue.Enqueue((root.left, root.right));
        while (queue.Count > 0)
        {
            (left, right) = queue.Dequeue();

            left.val ^= right.val;
            right.val ^= left.val;
            left.val ^= right.val;

            if (left.left != null && left.left.left != null)
            {
                queue.Enqueue((left.left.left, right.right.right));
                queue.Enqueue((left.left.right, right.right.left));
                queue.Enqueue((left.right.left, right.left.right));
                queue.Enqueue((left.right.right, right.left.left));
            }
        }

        return root;
    }
}
// @lc code=end

