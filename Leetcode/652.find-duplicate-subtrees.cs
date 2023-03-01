/*
 * @lc app=leetcode id=652 lang=csharp
 *
 * [652] Find Duplicate Subtrees
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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var dict = new Dictionary<string, int>();
        var result = new List<TreeNode>();

        IList<char> Dfs(TreeNode node)
        {
            if (node == null)
            {
                return new List<char>() {
                    'n', 'u', 'l', 'l'
                };
            }

            var rst = new List<char>();
            rst.AddRange(node.val.ToString().ToCharArray());
            rst.Add(',');
            rst.AddRange(Dfs(node.left));
            rst.AddRange(Dfs(node.right));

            var s = new string(rst.ToArray());

            if (dict.TryGetValue(s, out int count))
            {
                if (count == 1)
                {
                    result.Add(node);
                }
            }
            else
            {
                dict[s] = 0;
            }
            dict[s]++;

            return rst;
        }

        Dfs(root);

        return result;
    }
}
// @lc code=end

