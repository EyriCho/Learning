/*
 * @lc app=leetcode id=2331 lang=csharp
 *
 * [2331] Evaluate Boolean Binary Tree
 */

// @lc code=start
public class Solution {
    public bool EvaluateTree(TreeNode root) {
        if (root.val == 1 ||
            root.val == 0)
        {
            return Convert.ToBoolean(root.val);
        }

        if (root.val == 2)
        {
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        }
        else
        {
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
    }
}
// @lc code=end

