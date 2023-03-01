/*
 * @lc app=leetcode id=1011 lang=csharp
 *
 * [1011] Capacity To Ship Packages Within D Days
 */

// @lc code=start
public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        var max = 0;
        var total = 0;
        foreach (var weight in weights)
        {
            max = Math.Max(weight, max);
            total += weight;
        }

        int l = max, r = total;
        while (l < r)
        {
            var mid = (l + r) >> 1;

            int cur = 0, d = 1;
            foreach (var weight in weights)
            {
                if (cur + weight > mid)
                {
                    cur = 0;
                    d++;
                }

                cur += weight;
            }

            if (d > days)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }
}
// @lc code=end

