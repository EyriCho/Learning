/*
 * @lc app=leetcode id=1557 lang=csharp
 *
 * [1557] Minimum Number of Vertices to Reach All Nodes
 */

// @lc code=start
public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        var reachable = new bool[n];

        foreach (var edge in edges)
        {
            reachable[edge[1]] = true;
        }

        var result = new List<int>(n);
        for (int i = 0; i < n; i++)
        {
            if (!reachable[i])
            {
                result.Add(i);
            }
        }

        return result;
    }
}
// @lc code=end

