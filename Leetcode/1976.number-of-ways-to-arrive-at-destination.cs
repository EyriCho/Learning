/*
 * @lc app=leetcode id=1976 lang=csharp
 *
 * [1976] Number of Ways to Arrive at Destination
 */

// @lc code=start
public class Solution {
    public int CountPaths(int n, int[][] roads) {
        List<(int, int)>[] maps = new List<(int, int)>[n];
        long[] arrivals = new long[n];
        long[] counts = new long[n];
        for (int i = 0; i < n; i++)
        {
            maps[i] = new ();
            arrivals[i] = long.MaxValue;
        }

        foreach (int[] road in roads)
        {
            maps[road[0]].Add((road[1], road[2]));
            maps[road[1]].Add((road[0], road[2]));
        }

        PriorityQueue<(int, long), long> queue = new ();
        queue.Enqueue((0, 0), 0);
        counts[0] = 1L;

        int u = 0;
        long time = 0L,
            vTime = 0L;

        while (queue.Count > 0)
        {
            (u, time) = queue.Dequeue();

            if (time > arrivals[u])
            {
                continue;
            }

            foreach ((int v, int cost) in maps[u])
            {
                vTime = time + cost;
                if (vTime < arrivals[v])
                {
                    arrivals[v] = vTime;
                    counts[v] = counts[u];
                    queue.Enqueue((v, vTime), vTime);
                }
                else if (vTime == arrivals[v])
                {
                    counts[v] = (counts[v] + counts[u]) % 1_000_000_007L;
                }
            }
        }

        return (int)counts[n - 1];
    }
}
// @lc code=end

