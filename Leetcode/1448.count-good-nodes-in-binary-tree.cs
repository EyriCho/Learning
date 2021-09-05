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
        int result = 0;
        
        void Dfs(TreeNode node, int max)
        {
            if (node == null)
                return;
            if (node.val >= max)
                result++;
            
            max = Math.Max(max, node.val);
            Dfs(node.left, max);
            Dfs(node.right, max);
        }
        
        Dfs(root, int.MinValue);
        return result;
    }
}
// @lc code=end

