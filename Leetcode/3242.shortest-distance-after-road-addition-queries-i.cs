/*
 * @lc app=leetcode id=3242 lang=csharp
 *
 * [3242] Shortest Distance After Road Addition Queries I 
 */

// @lc code=start
public class Solution {
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries) {
        int[] paths = new int[n];
        List<int>[] maps = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            paths[i] = i;
            maps[i] = new () {
                i + 1,
            };
        }

        void Dfs(int from, int s)
        {
            Queue<int> queue = new ();
            queue.Enqueue(from);
            int count = 0,
                node = 0;

            while (queue.Count > 0)
            {
                count = queue.Count;
                while (count-- > 0)
                {
                    node = queue.Dequeue();
                    if (paths[node] <= s)
                    {
                        continue;
                    }

                    paths[node] = Math.Min(paths[node], s);

                    if (node == n - 1)
                    {
                        continue;
                    }

                    foreach (int next in maps[node])
                    {
                        queue.Enqueue(next);
                    }
                }
                s++;
            }

        }

        int[] result = new int[queries.Length];
        int current = 0,
            p = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            maps[queries[i][0]].Add(queries[i][1]);
            Dfs(queries[i][1], paths[queries[i][0]] + 1);

            result[i] = paths[^1];
        }

        return result;
    }
}
// @lc code=end

