/*
 * @lc app=leetcode id=3620 lang=csharp
 *
 * [3620] Network Recovery Pathways
 */

// @lc code=start
public class Solution {
    public int FindMaxPathScore(int[][] edges, bool[] online, long k) {
        List<(int next, int cost)>[] maps = new List<(int, int)>[online.Length];
        for (int i = 0; i < online.Length; i++)
        {
            maps[i] = new ();
        }

        int l = int.MaxValue, r = 0,
            m = 0;
        int[] inCounts = new int[online.Length];
        foreach (int[] edge in edges)
        {
            if (!online[edge[0]] || !online[edge[1]])
            {
                continue;
            }

            maps[edge[0]].Add((edge[1], edge[2]));
            inCounts[edge[1]]++;

            l = Math.Min(l, edge[2]);
            r = Math.Max(r, edge[2]);
        }

        Queue<int> queue = new ();
        for (int i = 1; i < online.Length; i++)
        {
            if (inCounts[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int node = 0;
        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            foreach ((int next, _) in maps[node])
            {
                if (--inCounts[next] == 0 && next != 0)
                {
                    queue.Enqueue(next);
                }
            }
        }

        bool Check(int minCost)
        {
            long[] dp = new long[online.Length];
            Array.Fill(dp, long.MaxValue >> 1);
            dp[0] = 0L;

            int[] counts = (int[])inCounts.Clone();

            Queue<int> queue = new ();
            queue.Enqueue(0);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node == online.Length - 1)
                {
                    return dp[node] <= k;
                }

                foreach ((int next, int c) in maps[node])
                {
                    if (c >= minCost)
                    {
                        dp[next] = Math.Min(dp[node] + c, dp[next]);
                    }
                    
                    if (--counts[next] == 0)
                    {
                        queue.Enqueue(next);
                    }
                }
            }

            return false;
        }

        if (!Check(l))
        {
            return -1;
        }

        while (l <= r)
        {
            m = (l + r) >> 1;
            if (Check(m))
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return r;
    }
}
// @lc code=end

