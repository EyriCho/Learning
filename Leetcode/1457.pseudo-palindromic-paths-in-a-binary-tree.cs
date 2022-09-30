    /*
 * @lc app=leetcode id=1457 lang=csharp
 *
 * [1457] Pseudo-Palindromic Paths in a Binary Tree
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
    public int PseudoPalindromicPaths (TreeNode root) {
        int DFS(TreeNode node, int path)
        {
            path ^= 1 << node.val;
            
            int result = 0;
            if (node.left == null && node.right == null)
            {
                if ((path & path -1) == 0)
                {
                    return 1;
                }
            }
            else
            {
                if (node.left != null)
                {
                    result += DFS(node.left, path);
                }
                
                if (node.right != null)
                {
                    result += DFS(node.right, path);
                }
            }
            
            return result;
        }
        
        return DFS(root, 0);
    }
}
// @lc code=end

