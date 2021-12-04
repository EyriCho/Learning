/*
 * @lc app=leetcode id=993 lang=csharp
 *
 * [993] Cousins in Binary Tree
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
    public bool IsCousins(TreeNode root, int x, int y) {
        var queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((null, root));
        
        while (queue.Count > 0)
        {
            var count = queue.Count;
            TreeNode xParent = null,
                yParent = null;
            
            while (count-- > 0)
            {
                var (parent , node) = queue.Dequeue();
                if (node.val == x)
                {
                    if (yParent != null && yParent != parent)
                        return true;
                    xParent = parent;
                }
                if (node.val == y)
                {
                    if (xParent != null && xParent != parent)
                        return true;
                    yParent = parent;
                }
                
                if (node.left != null)
                    queue.Enqueue((node, node.left));
                if (node.right != null)
                    queue.Enqueue((node, node.right));
            }
        }
        
        return false;
    }
}
// @lc code=end

