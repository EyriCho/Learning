/*
 * @lc app=leetcode id=3559 lang=csharp
 *
 * [3559] Number of Ways to Assign Edge Weights II
 */

// @lc code=start
public class Solution {
    public int[] AssignEdgeWeights(int[][] edges, int[][] queries) {
        int[] pows = new int[100_002];
        pows[0] = 1;
        for (int i = 1; i < pows.Length; i++)
        {
            pows[i] = (int)(pows[i - 1] * 2L % 1_000_000_007L);
        }

        List<int>[] maps = new List<int>[edges.Length + 2];
        foreach (int[] edge in edges)
        {
            if (maps[edge[0]] == null)
            {
                maps[edge[0]] = new ();
            }

            if (maps[edge[1]] == null)
            {
                maps[edge[1]] = new ();
            }

            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        int _log = (int)(Math.Log(edges.Length + 1) / Math.Log(2)) + 1;
        int[] depths = new int[maps.Length];
        int[,] st = new int[maps.Length, _log];

        void Dfs(int idx, int parent)
        {
            depths[idx] = depths[parent] + 1;
            st[idx, 0] = parent;

            foreach (int next in maps[idx])
            {
                if (next == parent)
                {
                    continue;
                }

                Dfs(next, idx);
            }
        }

        int Lca(int a, int b)
        {
            if (depths[a] > depths[b])
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }

            int diff = depths[b] - depths[a];
            for (int j = _log - 1; j >= 0; j--)
            {
                if ((diff & (1 << j)) > 0)
                {
                    b = st[b, j];
                }
            }

            if (a == b)
            {
                return a;
            }

            for (int j = _log - 1; j >= 0; j--)
            {
                if (st[a, j] != st[b, j])
                {
                    a = st[a, j];
                    b = st[b, j];
                }
            }

            return st[a, 0];
        }

        Dfs(1, 0);
        for (int j = 1; j < _log; j++)
        {
            for (int i = 1; i < maps.Length; i++)
            {
                st[i, j] = st[st[i, j - 1], j - 1];
            }
        }

        int[] result = new int[queries.Length];
        int ancestor = 0,
            distance = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            if (queries[i][0] == queries[i][1])
            {
                continue;
            }

            ancestor = Lca(queries[i][0], queries[i][1]);
            distance = depths[queries[i][0]] + depths[queries[i][1]] - depths[ancestor] * 2;

            result[i] = pows[distance - 1];
        }

        return result;
    }
}
// @lc code=end

