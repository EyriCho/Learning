/*
 * @lc app=leetcode id=653 lang=csharp
 *
 * [653] Two Sum IV - Input is a BST
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
    public bool FindTarget(TreeNode root, int k) {
        var set = new HashSet<int>();
        
        bool Travel(TreeNode node)
        {
            if (node == null)
                return false;
            
            if (set.Contains(k - node.val))
                return true;
            if (!set.Contains(node.val))
                set.Add(node.val);
            
            return Travel(node.left) || Travel(node.right);
        }
        
        return Travel(root);
    }
}
// @lc code=end

