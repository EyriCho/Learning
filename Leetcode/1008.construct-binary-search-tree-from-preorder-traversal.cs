/*
 * @lc app=leetcode id=1008 lang=csharp
 *
 * [1008] Construct Binary Search Tree from Preorder Traversal
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
    public TreeNode BstFromPreorder(int[] preorder) {
        int i = 0;
        
        TreeNode Helper(int max)
        {
            if (i < preorder.Length && preorder[i] < max)
            {
                var node = new TreeNode(preorder[i]);
                i++;
                node.left = Helper(node.val);
                node.right = Helper(max);
                return node;
            }
            
            return null;
        }
        
        return Helper(int.MaxValue);
    }
}
// @lc code=end

