/*
 * @lc app=leetcode id=1305 lang=csharp
 *
 * [1305] All Elements in Two Binary Search Trees
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        root1 = Flattern(root1);
        root2 = Flattern(root2);
        var result = new List<int>();
        
        while (root1 != null || root2 != null)
        {
            if (root2 == null || (root1 != null && root1.val <= root2.val))
            {
                result.Add(root1.val);
                root1 = root1.right;
            }
            else
            {
                result.Add(root2.val);
                root2 = root2.right;
            }
        }            
        
        return result;
    }
    
    private TreeNode Flattern(TreeNode root)
    {
        var node = root;
        var upper = root;
        while (node != null)
        {
            if (node.left == null)
            {
                upper = node;
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null)
                    prev = prev.right;
                
                prev.right = node;
                node = node.left;
                if (root == prev.right)
                    root = node;
                else
                    upper.right = node;
                prev.right.left = null;
            }
        }
        return root;
    }
}
// @lc code=end

