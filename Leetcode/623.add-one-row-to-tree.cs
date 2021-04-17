/*
 * @lc app=leetcode id=623 lang=csharp
 *
 * [623] Add One Row to Tree
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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if (d == 1)
            return new TreeNode(v, root);
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int l = 2;
        while (l < d)
        {
            var c = queue.Count();
            while (c-- > 0)
            {
                var node = queue.Dequeue();
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            l++;
        }
        
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            node.left = new TreeNode(v, node.left);
            node.right = new TreeNode(v, null, node.right);
        }
        
        return root;
    }
}
// @lc code=end

