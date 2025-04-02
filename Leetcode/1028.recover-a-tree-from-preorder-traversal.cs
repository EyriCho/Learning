/*
 * @lc app=leetcode id=1028 lang=csharp
 *
 * [1028] Recover a Tree From Preorder Traversal
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
    public TreeNode RecoverFromPreorder(string traversal) {
        Stack<TreeNode> stack = new ();
        TreeNode temp = new (),
            parent = null;

        int i = 0,
            depth = 0,
            num = 0;
        while (i < traversal.Length)
        {
            depth = 0;
            while (traversal[i] == '-')
            {
                depth++;
                i++;
            }

            num = 0;
            while (i < traversal.Length && traversal[i] != '-')
            {
                num = num * 10 + traversal[i] - '0';
                i++;
            }

            while (stack.Count > depth)
            {
                stack.Pop();
            }
    
            TreeNode node = new (num);        
            if (stack.TryPeek(out parent))
            {
                if (parent.left == null)
                {
                    parent.left = node;
                }
                else
                {
                    parent.right = node;
                }
            }
            stack.Push(node);
        }

        return stack.LastOrDefault();
    }
}
// @lc code=end

