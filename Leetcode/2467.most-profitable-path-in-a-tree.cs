/*
 * @lc app=leetcode id=2467 lang=csharp
 *
 * [2467] Most Profitable Path in a Tree 
 */

// @lc code=start
public class Solution {
    public int MostProfitablePath(int[][] edges, int bob, int[] amount) {
        List<int>[] maps = new List<int>[edges.Length + 1];
        bool[] visited = new bool[edges.Length + 1];
        for (int i = 0; i < maps.Length; i++)
        {
            maps[i] = new ();
        }
        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        int max = int.MinValue;

        (int income, int depth) Travel(int node, int level)
        {
            int i = int.MinValue,
                b = -1,
                c = 0;

            visited[node] = true;
            foreach (int n in maps[node])
            {
                if (visited[n])
                {
                    continue;
                }

                (int cIncome, int bLevel) = Travel(n, level + 1);
                i = Math.Max(i ,cIncome);
                if (b == -1)
                {
                    b = bLevel == -1 ? -1 : (bLevel + 1);
                }
                c++;
            }

            if (c == 0)
            {
                i = 0;
                b = -1;
            }

            if (node == bob)
            {
                b = 0;
            }

            if (b == -1 || level < b)
            {
                i += amount[node];
            }
            else if (level == b)
            {
                i += amount[node] >> 1;
            }

            return (i, b);
        }

        return Travel(0, 0).income;
    }
}
// @lc code=end

