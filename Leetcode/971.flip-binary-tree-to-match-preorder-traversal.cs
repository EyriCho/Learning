/*
 * @lc app=leetcode id=971 lang=csharp
 *
 * [971] Flip Binary Tree To Match Preorder Traversal
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
    public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage) {
        var result = new List<int>();
        var i = Flip(root, voyage, 0, result);
        if (i == -1)
        {    
            result.Clear();
            result.Add(-1);
        }
        return result;
    }
    
    private int Flip(TreeNode root, int[] voyage, int i, IList<int> result)
    {
        if (root == null)
            return i;
        
        if (root.val != voyage[i])
            return -1;
        
        var next = i + 1;
        if (root.left != null && next < voyage.Length &&
           root.left.val == voyage[next])
        {
            next = Flip(root.left, voyage, next, result);
            if (next == -1)
                return -1;
            return Flip(root.right, voyage, next, result);
        }
        else if (root.right != null && next < voyage.Length &&
                root.right.val == voyage[next])
        {
            if (root.left != null)
                result.Add(root.val);
            next = Flip(root.right, voyage, next, result);
            if (next == -1)
                return -1;
            return Flip(root.left, voyage, next, result);
        }
        else if (root.left == null && root.right == null)
            return next;
        else 
            return -1;
    }
}
// @lc code=end

