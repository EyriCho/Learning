/*
 * @lc app=leetcode id=2070 lang=csharp
 *
 * [2070] Most Beautiful Item for Each Query
 */

// @lc code=start
public class Solution {
    public int[] MaximumBeauty(int[][] items, int[] queries) {
        Array.Sort(items, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

        for (int i = 1; i < items.Length; i++)
        {
            items[i][1] = Math.Max(items[i][1], items[i - 1][1]);
        }

        int l = 0,
            r = 0,
            m = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            l = 0;
            r = items.Length;

            while (l < r)
            {
                m = (l + r) >> 1;
                if (items[m][0] <= queries[i])
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            queries[i] = l == 0 ? 0 : items[l - 1][1];
        }

        return queries;
    }
}
// @lc code=end

