/*
 * @lc app=leetcode id=2101 lang=csharp
 *
 * [2101] Detonate the Maximum Bombs
 */

// @lc code=start
public class Solution {
    public int MaximumDetonation(int[][] bombs) {
        var denotes = new List<int>[bombs.Length];

        for (int i = 0; i < bombs.Length; i++)
        {
            denotes[i] = new List<int>();

            for (int j = 0; j < bombs.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if ((long)(bombs[i][0] - bombs[j][0]) * (bombs[i][0] - bombs[j][0]) +
                    (long)(bombs[i][1] - bombs[j][1]) * (bombs[i][1] - bombs[j][1]) <=
                    (long)bombs[i][2] * bombs[i][2])
                {
                    denotes[i].Add(j);
                }
            }
        }

        var result = 0;
        for (int i = 0; i < bombs.Length; i++)
        {
            var visited = new bool[bombs.Length];
            var queue = new Queue<int>();
            queue.Enqueue(i);
            var count = 0;

            while (queue.Count > 0)
            {
                var index = queue.Dequeue();
                if (visited[index])
                {
                    continue;
                }
                visited[index] = true;
                count++;

                foreach (var next in denotes[index])
                {
                    queue.Enqueue(next);
                }
            }

            result = Math.Max(count, result);
        }

        return result;
    }
}
// @lc code=end

