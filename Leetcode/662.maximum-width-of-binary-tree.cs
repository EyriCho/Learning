/*
 * @lc app=leetcode id=662 lang=csharp
 *
 * [662] Maximum Width of Binary Tree
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
    public int WidthOfBinaryTree(TreeNode root) {
        int result = 0;
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));
        while (queue.Count() > 0)
        {
            int levelCount = queue.Count();
            int levelMinIndex = 0, levelMaxIndex = 0;
            for (int i = 0; i < levelCount; i++)
            {
                var (node, index) = queue.Dequeue();
                if (i == 0) levelMinIndex = index;
                if (i == levelCount - 1) levelMaxIndex = index;
                
                if (node.left != null) queue.Enqueue((node.left, (index - levelMinIndex) * 2));
                if (node.right != null) queue.Enqueue((node.right, (index - levelMinIndex) * 2 + 1));
            }
            
            var levelWidth = levelMaxIndex - levelMinIndex + 1;
            result = levelWidth > result ?
                levelWidth : result;
        }

        return result;
    }
}
// @lc code=end

