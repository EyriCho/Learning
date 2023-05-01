/*
 * @lc app=leetcode id=1372 lang=csharp
 *
 * [1372] Longest ZigZag Path in a Binary Tree
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
    public int LongestZigZag(TreeNode root) {
        int result = 0;
        
        int Dfs(TreeNode node, bool? isLeft)
        {
            if (node == null)
            {
                return 0;
            }

            int l = Dfs(node.left, true);
            int r = Dfs(node.right, false);
            result = Math.Max(result, Math.Max(l, r));
            if (isLeft == null)
            {
                return Math.Max(l, r);
            }
            else if (isLeft == true)
            {
                return r + 1;
            }
            else
            {
                return l + 1;
            }
        }

        Dfs(root, null);
        return result;
    }
}
// @lc code=end

