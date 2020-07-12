/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;


        var preIndex = 1;
        var result = new TreeNode(preorder[preIndex - 1]);
        if (preorder.Length > 1)
        {
            var inorderDic = new Dictionary<int, int>();
            for (var i = 0; i < inorder.Length; i++)
            {
                inorderDic[inorder[i]] = i;
            }

            var inIndex = inorderDic[result.val];
            var stack = new Stack<(TreeNode, bool, int, int)>();
            if (inIndex + 1 < inorder.Length)
                stack.Push((result, false, inIndex + 1, inorder.Length));
            if (inIndex > 0)
                stack.Push((result, true, 0, inIndex));
            while (stack.Count != 0)
            {
                var (pnode, isLeft, inStart, inEnd) = stack.Pop();

                var node = new TreeNode(preorder[preIndex]);
                
                if (isLeft)
                    pnode.left = node;
                else
                    pnode.right = node;
                
                inIndex = inorderDic[node.val];

                if (inIndex + 1 < inEnd)
                    stack.Push((node, false, inIndex + 1, inEnd));
                if (inIndex > inStart)
                    stack.Push((node, true, inStart, inIndex));
                
                preIndex++;
            }
        }

        return result;
    }
}
// @lc code=end

