/*
 * @lc app=leetcode id=1443 lang=csharp
 *
 * [1443] Minimum Time to Collect All Apples in a Tree
 */

// @lc code=start
public class Solution {
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {
        var maps = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            maps[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];

        int Travel(int i)
        {
            var count = 0;
            foreach (var child in maps[i])
            {
                if (!visited[child])
                {
                    visited[child] = true;
                    count += Travel(child);
                }
            }

            if (count > 0 || hasApple[i])
            {
                count += 2;
            }
            return count;
        }

        visited[0] = true;
        var result = Travel(0);

        return result > 0 ? (result - 2) : 0;
    }
}
// @lc code=end

