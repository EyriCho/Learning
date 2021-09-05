/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var result = new List<IList<int>>();
        
        var temp = new List<int>();
        void Find(TreeNode node, int left)
        {
            if (node == null)
                return;
            
            temp.Add(node.val);
            left -= node.val;
            if (left == 0 && node.left == null && node.right == null)
            {
                result.Add(new List<int>(temp));
                temp.RemoveAt(temp.Count - 1);
                return;
            }
            
            if (node.left != null)
                Find(node.left, left);
            if (node.right != null)
                Find(node.right, left);
            
            temp.RemoveAt(temp.Count - 1);
        }
        Find(root, targetSum);
        
        
        return result;
    }
}
// @lc code=end

