/*
 * @lc app=leetcode id=1514 lang=csharp
 *
 * [1514] Path with Maximum Probability
 */

// @lc code=start
public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end) {
        var maps = new List<(int, double)>[n];
        
        for (int i = 0; i < edges.Length; i++)
        {
            var a = edges[i][0];
            var b = edges[i][1];
            var p = succProb[i];

            if (maps[a] == null)
            {
                maps[a] = new List<(int, double)>();
            }
            maps[a].Add((b, p));

            if (maps[b] == null)
            {
                maps[b] = new List<(int, double)>();
            }
            maps[b].Add((a, p));
        }

        var dp = new double[n];
        dp[start] = 1D;
        var queue = new Queue<int>();
        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (maps[node] == null)
            {
                continue;
            }
            if (node == end)
            {
                continue;
            }
            foreach (var (next, p) in maps[node])
            {
                if (dp[node] * p > dp[next])
                {
                    dp[next] = dp[node] * p;
                    queue.Enqueue(next);
                }
            }
        }
        
        return dp[end];
    }
}
// @lc code=end

