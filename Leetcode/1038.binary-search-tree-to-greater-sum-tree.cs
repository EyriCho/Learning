/*
 * @lc app=leetcode id=1038 lang=csharp
 *
 * [1038] Binary Search Tree to Greater Sum Tree
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
    public TreeNode BstToGst(TreeNode root) {
        int sum = 0;

        void Travel(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            
            Travel(node.right);
            sum += node.val;
            node.val = sum;
            Travel(node.left);
        }

        Travel(root);
        return root;
    }
}
// @lc code=end

