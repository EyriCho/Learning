/*
 * @lc app=leetcode id=1697 lang=csharp
 *
 * [1697] Checking Existence of Edge Length Limited Paths
 */

// @lc code=start
public class Solution {
    public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries) {
        Array.Sort(edgeList, (a, b) => a[2] - b[2]);

        var q = new (int, int, int, int)[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            q[i] = (queries[i][0], queries[i][1], queries[i][2], i);
        }
        Array.Sort(q, (a, b) => a.Item3 - b.Item3);

        var group = new int[n];
        for (int i = 0; i < n; i++)
        {
            group[i] = i;
        }

        int FindGroup(int i)
        {
            if (group[i] != i)
            {
                return group[i] = FindGroup(group[i]);
            }
            return i;
        }

        var edgeIndex = 0;
        var result = new bool[queries.Length];
        foreach (var (from, to, limit, i) in q)
        {
            while (edgeIndex < edgeList.Length &&
                edgeList[edgeIndex][2] < limit)
            {
                int gu = FindGroup(edgeList[edgeIndex][0]),
                    gv = FindGroup(edgeList[edgeIndex][1]);

                if (gu != gv)
                {
                    group[gu] = gv;
                }

                edgeIndex++;
            }

            int f = FindGroup(from),
                t = FindGroup(to);

            if (f == t)
            {
                result[i] = true;
            }
        }
        return result;
    }
}
// @lc code=end

