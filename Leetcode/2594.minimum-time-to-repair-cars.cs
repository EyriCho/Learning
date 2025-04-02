/*
 * @lc app=leetcode id=2594 lang=csharp
 *
 * [2594] Minimum Time to Repair Cars
 */

// @lc code=start
public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        Dictionary<int, long> dict = new();
        long min = 100,
            l = 1L,
            m = 0L,
            count = 0L,
            r = min * cars * cars;
        foreach (int rank in ranks)
        {
            min = Math.Min(min, rank);
            dict.TryGetValue(rank, out count);
            dict[rank] = count + 1;
        }

        while (l < r)
        {
            m = (l + r) >> 1;
            count = 0L;

            foreach (KeyValuePair<int, long> kv in dict)
            {
                count += (long)Math.Sqrt((double)m / kv.Key) * kv.Value;
            }

            if (count >= cars)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return l;
    }
}
// @lc code=end

