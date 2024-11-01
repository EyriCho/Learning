/*
 * @lc app=leetcode id=2458 lang=csharp
 *
 * [2458] Height of Binary Tree After Subtree Removal Queries 
 */

// @lc code=start
public class Solution {
    public int[] TreeQueries(TreeNode root, int[] queries) {
        Dictionary<TreeNode, int> heightDict = new ();
        int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            heightDict[node] = 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
            return heightDict[node];
        }
        GetHeight(root);

        int[] result = new int[heightDict.Count + 1];
        void Dfs(TreeNode node, int depth, int heightAfterRemove)
        {
            if (node == null)
            {
                return;
            }

            depth++;
            result[node.val] = heightAfterRemove;
            Dfs(node.left, depth, Math.Max(heightAfterRemove, depth + (node.right == null ? 0 : heightDict[node.right])));
            Dfs(node.right, depth, Math.Max(heightAfterRemove, depth + (node.left == null ? 0 : heightDict[node.left])));
        }
        Dfs(root, -1, 0);

        for (int i = 0; i < queries.Length; i++)
        {
            queries[i] = result[queries[i]];
        }
        return queries;
    }
}
// @lc code=end

