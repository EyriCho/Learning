/*
 * @lc app=leetcode id=889 lang=csharp
 *
 * [889] Construct Binary Tree from Preorder and Postorder Traversal
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
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        TreeNode root = new (preorder[0]),
            node = null;
        Stack<TreeNode> stack = new ();
        stack.Push(root);
        int postIndex = 0;
        for (int preIndex = 1; preIndex < preorder.Length; preIndex++)
        {
            while (stack.Peek().val == postorder[postIndex])
            {
                stack.Pop();
                postIndex++;
            }

            node = new (preorder[preIndex]);
            if (stack.Peek().left == null)
            {
                stack.Peek().left = node;
            }
            else
            {
                stack.Peek().right = node;
            }
            stack.Push(node);
        }

        return root;
    }
}
// @lc code=end

