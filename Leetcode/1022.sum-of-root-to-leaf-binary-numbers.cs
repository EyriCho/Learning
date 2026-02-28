/*
 * @lc app=leetcode id=1022 lang=csharp
 *
 * [1022] Sum of Root To Leaf Binary Numbers
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
    public int SumRootToLeaf(TreeNode root) {
        int sum = 0;

        void Sum(TreeNode node, int accumulate)
        {
            accumulate = (accumulate << 1) + node.val;

            if (node.left == null && node.right == null)
            {
                sum += accumulate;
                return;
            }
            
            if (node.left != null)
            {
                Sum(node.left, accumulate);
            }

            if (node.right != null)
            {
                Sum(node.right, accumulate);
            }
        }

        Sum(root, 0);

        return sum;
    }
}
// @lc code=end

