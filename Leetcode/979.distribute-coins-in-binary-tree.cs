/*
 * @lc app=leetcode id=979 lang=csharp
 *
 * [979] Distribute Coins in Binary Tree
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
    public int DistributeCoins(TreeNode root) {
        int result = 0;

        int Distribute(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int l = Distribute(node.left),
                r = Distribute(node.right);

            result += Math.Abs(l) + Math.Abs(r);

            return l + r + node.val - 1;
        }

        Distribute(root);
        return result;
    }
}
// @lc code=end

