/*
 * @lc app=leetcode id=3414 lang=csharp
 *
 * [3414] Maximum Score of Non-overlapping Intervals
 */

// @lc code=start
public class Solution {
    public int[] MaximumWeight(IList<IList<int>> intervals) {
        int[] idxes = new int[intervals.Count];
        for (int i = 0; i < intervals.Count; i++)
        {
            idxes[i] = i;
        }
        Array.Sort(idxes, (a, b) => !intervals[a][0].Equals(intervals[b][1]) ?
            intervals[a][0].CompareTo(intervals[b][0]) :
            (!intervals[a][1].Equals(intervals[b][1]) ?
                intervals[a][1].CompareTo(intervals[b][1]) :
                a.CompareTo(b)));

        bool isLess(IList<int> a, IList<int> b)
        {
            if (b.Count == 0)
            {
                return true;
            }
            for (int j = 0; j < Math.Min(a.Count, b.Count); j++)
            {
                if (a[j] != b[j])
                {
                    return a[j] < b[j];
                }
            }
            return a.Count < b.Count;
        }

        (long w, IList<int> list)[,] dp = new (long, IList<int>)[intervals.Count + 1, 5];
        for (int i = 0; i <= intervals.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                dp[i, j] = (0L, new List<int>());
            }
        }

        int l = 0,
            m = 0,
            r = 0;

        (long w, IList<int> list) next = (0L, null),
            available = (0L, null);
        List<int> newList = null;
        long weight = 0L;
        for (int i = intervals.Count - 1; i >= 0; i--)
        {
            l = 0;
            r = intervals.Count;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (intervals[idxes[m]][0] > intervals[idxes[i]][1])
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            for (int j = 1; j < 5; j++)
            {
                next = dp[i + 1, j];
                available = dp[l, j - 1];
                newList = new List<int>(available.list) { idxes[i] };
                newList.Sort();
                weight = available.w + intervals[idxes[i]][2];

                dp[i, j] = weight > next.w || (weight == next.w && isLess(newList, next.list)) ? (weight, newList) : next;
            }

        }
        return dp[0, 4].list.ToArray();
    }
}
// @lc code=end

