/*
 * @lc app=leetcode id=1339 lang=csharp
 *
 * [1339] Maximum Product of Splitted Binary Tree
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
    public int MaxProduct(TreeNode root) {
        int Travel(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            node.val += Travel(node.left);
            node.val += Travel(node.right);

            return node.val;
        }

        long result = 0L,
            total = Travel(root);
                
        void Max(TreeNode node)
        {
            if (node.left != null)
            {
                result = Math.Max(result, (node.left.val * (total - node.left.val)));
                Max(node.left);
            }
            
            if (node.right != null)
            {
                result = Math.Max(result, (node.right.val * (total - node.right.val)));
                Max(node.right);
            }
        }
        Max(root);
        
        return (int)(result % 1_000_000_007);
    }
}
// @lc code=end

