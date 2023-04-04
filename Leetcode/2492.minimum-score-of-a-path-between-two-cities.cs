/*
 * @lc app=leetcode id=2492 lang=csharp
 *
 * [2492] Minimum Score of a Path Between Two Cities
 */

// @lc code=start
public class Solution {
    public int MinScore(int n, int[][] roads) {
        var maps = new IList<(int, int)>[n + 1];
        for (int i = 0; i <= n; i++)
        {
            maps[i] = new List<(int, int)>();
        }

        foreach (var road in roads)
        {
            maps[road[0]].Add((road[1], road[2]));
            maps[road[1]].Add((road[0], road[2]));
        }

        var result = int.MaxValue;
        var queue = new Queue<int>();
        queue.Enqueue(1);
        var visited = new bool[n + 1];
        visited[1] = true;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            foreach (var next in maps[node])
            {
                result = Math.Min(next.Item2, result);
                if (!visited[next.Item1])
                {
                    visited[next.Item1] = true;
                    queue.Enqueue(next.Item1);
                }
            }
        }

        return result;
    }
}
// @lc code=end

