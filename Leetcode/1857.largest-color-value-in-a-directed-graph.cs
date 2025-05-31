/*
 * @lc app=leetcode id=1857 lang=csharp
 *
 * [1857] Largest Color Value in a Directed Graph
 */

// @lc code=start
public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        List<int>[] maps = new List<int>[colors.Length];
        int[] prevs = new int[colors.Length];
        for (int i = 0; i < colors.Length; i++)
        {
            maps[i] = new ();
        }

        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            prevs[edge[1]]++;
        }

        int[,] groups = new int[colors.Length, 26];
        Queue<int> queue = new ();
        for (int i = 0; i < colors.Length; i++)
        {
            if (prevs[i] == 0)
            {
                queue.Enqueue(i);
                groups[i, colors[i] - 'a']++;
            }
        }

        int node = 0,
            c = 0,
            visited = 0,
            result = 1;
        while (queue.Count > 0)
        {
            node = queue.Dequeue();
            visited++;

            foreach (int next in maps[node])
            {
                for (c = 0; c < 26; c++)
                {
                    groups[next, c] = Math.Max(groups[next, c], groups[node, c]);
                }

                prevs[next]--;
                if (prevs[next] == 0)
                {
                    queue.Enqueue(next);
                    result = Math.Max(result, ++groups[next, colors[next] - 'a']);
                }
            }
        }

        return visited < colors.Length ? -1 : result;
    }
}
// @lc code=end

