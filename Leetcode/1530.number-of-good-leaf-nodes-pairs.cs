/*
 * @lc app=leetcode id=1530 lang=csharp
 *
 * [1530] Number of Good Leaf Nodes Pairs
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
    public int CountPairs(TreeNode root, int distance) {
        if (distance == 1)
        {
            return 0;
        }

        int result = 0;

        int[] Dfs(TreeNode node)
        {
            int[] rst = new int[distance];
            if (node == null)
            {
                return rst;
            }

            int[] left = Dfs(node.left);
            int[] right = Dfs(node.right);

            for (int i = 1; i < distance; i++)
            {
                for (int j = 1; j <= distance - i; j++)
                {
                    result += left[i] * right[j];
                }
            }

            for (int i = 2; i < distance; i++)
            {
                rst[i] = left[i - 1] + right[i - 1];
            }

            if (node.left == null && node.right == null)
            {
                rst[1] = 1;
            }
            return rst;
        }

        Dfs(root);
        return result;
    }
}
// @lc code=end

