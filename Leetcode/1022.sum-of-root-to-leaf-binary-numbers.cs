/*
 * @lc app=leetcode id=1022 lang=csharp
 *
 * [1022] Sum of Root To Leaf Binary Numbers
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
    public int SumRootToLeaf(TreeNode root) {
        return Sum(root, 0);
    }
    
    private int Sum(TreeNode node, int pathSum)
    {
        if (node == null)
            return 0;
        pathSum <<= 1;
        pathSum += node.val;
        
        if (node.left == null && node.right == null)
            return pathSum;
        return Sum(node.left, pathSum) + Sum(node.right, pathSum);
    }
}
// @lc code=end

