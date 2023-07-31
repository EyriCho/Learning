/*
 * @lc app=leetcode id=894 lang=csharp
 *
 * [894] All Possible Full Binary Trees
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
    public IList<TreeNode> AllPossibleFBT(int n) {
        var result = new List<TreeNode>();
        if (n % 2 == 0)
        {
            return result;
        }
        var root = new TreeNode();
        if (n == 1)
        {
            result.Add(root);
            return result;
        }

        for (int l = 1; l < n; l += 2)
        {
            foreach (var left in AllPossibleFBT(l))
            {
                foreach (var right in AllPossibleFBT(n - 1 - l))
                {
                    var node = new TreeNode() {
                        left = left,
                        right = right
                    };
                    result.Add(node);
                }
            }
        }

        return result;
    }
}
// @lc code=end

