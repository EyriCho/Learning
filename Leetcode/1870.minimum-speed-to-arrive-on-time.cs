/*
 * @lc app=leetcode id=1870 lang=csharp
 *
 * [1870] Minimum Speed to Arrive on Time
 */

// @lc code=start
public class Solution {
    public int MinSpeedOnTime(int[] dist, double hour) {
        int result = int.MaxValue,
            l = 1,
            r = 10_000_000,
            m = 0,
            last = dist.Length - 1;
        
        while (l <= r)
        {
            m = (l + r) >> 1;

            var total = 0D;
            for (int i = 0; i < last; i++)
            {
                total += Math.Ceiling((double)dist[i] / m);
            }
            total += (double)dist[last] / m;

            if (total <= hour)
            {
                result = Math.Min(result, m);
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

