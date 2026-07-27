/*
 * @lc app=leetcode id=3161 lang=csharp
 *
 * [3161] Block Placement Queries
 */

// @lc code=start
public class Solution {
    public IList<bool> GetResults(int[][] queries) {
        int max = 50_000;
        int[] bt = new int[max + 1];

        void Update(int x, int v)
        {
            for (; x <= max; x += (x & -x))
            {
                bt[x] = Math.Max(bt[x], v);
            }
        }

        int Query(int x)
        {
            int rst = 0;
            for (; x > 0; x -= (x & -x))
            {
                rst = Math.Max(rst, bt[x]);
            }
            return rst;
        }

        SortedSet<int> set = new () {
            0, max
        };
        foreach (int[] q in queries)
        {
            if (q[0] == 1)
            {
                set.Add(q[1]);
            }
        }

        List<int> list = new (set);
        for (int i = 1; i < list.Count; i++)
        {
            Update(list[i], list[i] - list[i - 1]);
        }

        int idx = 0,
            prev = 0,
            next = 0;
        List<bool> result = new ();
        for (int q = queries.Length - 1; q >= 0; q--)
        {
            if (queries[q][0] == 2)
            {
                idx = list.BinarySearch(queries[q][1]);
                if (idx < 0)
                {
                    idx = ~idx - 1;
                }

                prev = list[idx];
                result.Add(Math.Max(Query(prev), queries[q][1] - prev) >= queries[q][2]);
            }
            else
            {
                idx = list.BinarySearch(queries[q][1]);
                prev = idx > 0 ? list[idx - 1] : 0;
                next = idx < list.Count - 1 ? list[idx + 1] : max;

                Update(next, next - prev);
                list.RemoveAt(idx);
            }
        }

        result.Reverse();
        return result;
    }
}
// @lc code=end

