/*
 * @lc app=leetcode id=1857 lang=csharp
 *
 * [1857] Largest Color Value in a Directed Graph
 */

// @lc code=start
public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        var nexts = new List<int>[colors.Length];
        var prevs = new int[colors.Length];
        var group = new int[colors.Length, 26];

        for (int i = 0; i < colors.Length; i++)
        {
            nexts[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            nexts[edge[0]].Add(edge[1]);
            prevs[edge[1]]++;
        }

        var list = new List<int>();
        for (int i = 0; i < colors.Length; i++)
        {
            if (prevs[i] == 0)
            {
                list.Add(i);
                group[i, colors[i] - 'a']++;
            }
        }

        var visited = new bool[colors.Length];
        int result = 1;

        int l = 0, r = list.Count;
        while (l < r)
        {
            var node = list[l];
            l++;
            foreach (var next in nexts[node])
            {
                for (int c = 0; c < 26; c++)
                {
                    group[next, c] = Math.Max(group[next, c], group[node, c]);
                }

                prevs[next]--;
                if (prevs[next] == 0)
                {
                    list.Add(next);
                    r++;
                    var count = ++group[next, colors[next] - 'a'];
                    result = Math.Max(result, count);
                }
            }
        }

        if (list.Count != colors.Length)
        {
            return -1;
        }

        return result;
    }
}
// @lc code=end

