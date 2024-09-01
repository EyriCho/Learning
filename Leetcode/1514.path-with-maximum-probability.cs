/*
 * @lc app=leetcode id=1514 lang=csharp
 *
 * [1514] Path with Maximum Probability
 */

// @lc code=start
public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        List<(int, double)>[] maps = new List<(int, double)>[n];
        for (int i = 0; i < edges.Length; i++)
        {
            maps[edges[i][0]] = maps[edges[i][0]] ?? new();
            maps[edges[i][0]].Add((edges[i][1], succProb[i]));

            maps[edges[i][1]] = maps[edges[i][1]] ?? new();
            maps[edges[i][1]].Add((edges[i][0], succProb[i]));
        }

        double[] dp = new double[n];
        dp[start_node] = 1D;
        int node = 0;
        Queue<int> queue = new();
        queue.Enqueue(start_node);
        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            if (maps[node] == null)
            {
                continue;
            }
            if (node == end_node)
            {
                continue;
            }

            foreach ((int next, double p) in maps[node])
            {
                if (dp[node] * p > dp[next])
                {
                    dp[next] = dp[node] * p;
                    queue.Enqueue(next);
                }
            }
        }

        return dp[end_node];
    }
}
// @lc code=end

