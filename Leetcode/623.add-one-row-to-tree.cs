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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        int row = 1,
            count = 0;
        
        TreeNode fake = new (0, root),
            node = null;
        Queue<TreeNode> queue = new ();
        queue.Enqueue(fake);
        
        while (row < depth)
        {
            count = queue.Count;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            row++;
        }
        
        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            node.left = new TreeNode(val, node.left);        
            node.right = new TreeNode(val, null, node.right);
        }
        
        return fake.left;
    }
}
// @lc code=end

