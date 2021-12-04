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
        var result = 0;
        
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));
        
        while (queue.Count > 0)
        {
            var (node, sum) = queue.Dequeue();
            sum = sum * 10 + node.val;
            
            if (node.left == null && node.right == null)
                result += sum;
            else
            {
                if (node.left != null)
                    queue.Enqueue((node.left, sum));
                if (node.right != null)
                    queue.Enqueue((node.right, sum));
            }
        }
        
        return result;
    }
}
// @lc code=end

