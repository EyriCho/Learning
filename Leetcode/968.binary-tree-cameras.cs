/*
 * @lc app=leetcode id=968 lang=csharp
 *
 * [968] Binary Tree Cameras
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
    public int MinCameraCover(TreeNode root) {
        var sum = 0;
        
        int dfs(TreeNode node)
        {
            if (node == null)
                return 1;
            int l = dfs(node.left),
                r = dfs(node.right);
            if (l == 0 || r == 0)
            {
                sum++;
                return 2;
            }
            else if (l == 2 || r == 2)
                return 1;
            else
                return 0;
        }
        
        if (dfs(root) == 0)
            sum++;
        
        return sum;
    }
}
// @lc code=end

