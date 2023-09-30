/*
 * @lc app=leetcode id=95 lang=csharp
 *
 * [95] Unique Binary Search Trees II
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
    public IList<TreeNode> GenerateTrees(int n) {
        IList<TreeNode> Generate(int l, int r)
        {
            var result = new List<TreeNode>();
            if (l > r)
            {
                result.Add(null);
                return result;
            }
            
            for (int i = l; i <= r; i++)
            {
                var lefts = Generate(l, i - 1);
                var rights = Generate(i + 1, r);

                foreach (var left in lefts)
                {
                    foreach (var right in rights)
                    {
                        result.Add(new TreeNode(i, left, right));
                    }
                }
            }

            return result;
        }

        return Generate(1, n);
    }
}
// @lc code=end

