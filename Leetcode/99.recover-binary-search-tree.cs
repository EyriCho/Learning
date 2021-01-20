/*
 * @lc app=leetcode id=99 lang=csharp
 *
 * [99] Recover Binary Search Tree
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
    public void RecoverTree(TreeNode root) {
        TreeNode l = null, r = null;
        
        TreeNode node = root, prev = null;
        while (node != null)
        {
            if (node.left != null)
            {
                var p = node.left;
                while (p.right != null &&
                      p.right != node)
                    p = p.right;
                
                if (p.right == null)
                {
                    p.right = node;
                    node = node.left;
                    continue;
                }
                else
                {
                    p.right = null;
                }
            }
            
            if (prev != null && prev.val > node.val)
            {
                if (l == null) l = prev;
                r = node;
            }
            prev = node;
            node = node.right;
        }
        
        SwapNodeVal(l, r);
    }
    
    private void SwapNodeVal(TreeNode l, TreeNode r)
    {
        l.val ^= r.val;
        r.val ^= l.val;
        l.val ^= r.val;
    }
}
// @lc code=end

