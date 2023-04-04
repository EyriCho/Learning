/*
 * @lc app=leetcode id=2360 lang=csharp
 *
 * [2360] Longest Cycle in a Graph
 */

// @lc code=start
public class Solution {
    public int LongestCycle(int[] edges) {
        var visited = new bool[edges.Length];
        int result = -1;
        for (int i = 0; i < edges.Length; i++)
        {
            if (!visited[i])
            {
                var dict = new Dictionary<int, int>();
                var moves = 0;
                int x = i;
                while (true)
                {
                    dict[x] = ++moves;
                    visited[x] = true;

                    if (dict.ContainsKey(edges[x]))
                    {
                        result = Math.Max(result, dict[x] - dict[edges[x]] + 1);
                        break;
                    }

                    if (edges[x] == -1 || visited[edges[x]])
                    {
                        break;
                    }

                    x = edges[x];
                }
            }
        }

        return result;
    }
}
// @lc code=end

