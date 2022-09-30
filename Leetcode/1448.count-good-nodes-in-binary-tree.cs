/*
 * @lc app=leetcode id=1448 lang=csharp
 *
 * [1448] Count Good Nodes in Binary Tree
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
    public int GoodNodes(TreeNode root) {
        int Count(TreeNode node, int max)
        {
            if (node == null)
            {
                return 0;
            }
            
            if (node.val >= max)
            {
                return 1 + Count(node.left, node.val) + Count(node.right, node.val);
            }
            else
            {
                return Count(node.left, max) + Count(node.right, max);
            }
        }
        
        return Count(root, -10_000);
    }
}
// @lc code=end

