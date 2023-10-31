/*
 * @lc app=leetcode id=2050 lang=csharp
 *
 * [2050] Parallel Courses III
 */

// @lc code=start
public class Solution {
    public int MinimumTime(int n, int[][] relations, int[] time) {
        var next = new List<int>[n + 1];
        var depens = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            next[i] = new List<int>();
        }
        foreach (var relation in relations)
        {
            next[relation[0]].Add(relation[1]);
            depens[relation[1]]++;
        }

        var result = 0;
        var queue = new Queue<int>();
        var maxTimes = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            if (depens[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            var c = queue.Dequeue();
            var months = maxTimes[c] + time[c - 1];

            result = Math.Max(result, months);

            foreach (var nc in next[c])
            {
                maxTimes[nc] = Math.Max(maxTimes[nc], months);
                if (--depens[nc] == 0)
                {
                    queue.Enqueue(nc);
                }
            }
        }

        return result;
    }
}
// @lc code=end

