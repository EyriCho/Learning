/*
 * @lc app=leetcode id=1489 lang=csharp
 *
 * [1489] Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges) {
        var result = new List<IList<int>> {
            new List<int>(),
            new List<int>(),
        };

        var array = new (int, int, int, int)[edges.Length];
        for (int i = 0; i < edges.Length; i++)
        {
            array[i] = (i, edges[i][0], edges[i][1], edges[i][2]);
        }
        Array.Sort(array, (a, b) => a.Item4 - b.Item4);

        int Find(int[] g, int node)
        {
            if (g[node] != node)
            {
                g[node] = Find(g, g[node]);
            }

            return g[node];
        }

        int Weight(int exclude, int include)
        {
            var rst = 0;
            var group = new int[n];
            var count = n;
            for (int i = 0; i < n; i++)
            {
                group[i] = i;
            }
            if (include >= 0)
            {
                group[array[include].Item2] = array[include].Item3;
                rst += array[include].Item4;
                count--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == exclude || i == include)
                {
                    continue;
                }

                var (_, a, b, w) = array[i];
                int rootA = Find(group, a),
                    rootB = Find(group, b);
                if (rootA != rootB)
                {
                    group[rootA] = rootB;
                    rst += w;
                    count--;

                    if (count == 1)
                    {
                        return rst;
                    }
                }
            }

            return int.MaxValue;
        }

        var minWeight = Weight(-1, -1);
        for (int i = 0; i < array.Length; i++)
        {
            if (Weight(i, -1) > minWeight)
            {
                result[0].Add(array[i].Item1);
            }
            else if (Weight(-1, i) == minWeight)
            {
                result[1].Add(array[i].Item1);
            }
        }

        return result;
    }
}
// @lc code=end

