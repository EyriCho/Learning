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
        IList<TreeNode> Build(int start, int end)
        {
            var result = new List<TreeNode>();
            if (start > end)
            {
                result.Add(null);
                return result;
            }
            
            for (int i = start; i <= end; i++)
            {
                var lefts = Build(start, i - 1);
                var rights = Build(i + 1, end);
                
                for (int j = 0; j < lefts.Count; j++)
                    for (int k = 0; k < rights.Count; k++)
                    {
                        var node = new TreeNode(i);
                        node.left = lefts[j];
                        node.right = rights[k];
                        result.Add(node);
                    }
            }
            return result;
        }
        
        return Build(1, n);
    }
}
// @lc code=end

