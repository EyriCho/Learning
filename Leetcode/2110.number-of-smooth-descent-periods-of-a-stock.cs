/*
 * @lc app=leetcode id=2110 lang=csharp
 *
 * [2110] Number of Smooth Descent Periods of a Stock
 */

// @lc code=start
public class Solution {
    public long GetDescentPeriods(int[] prices) {
        int l = 0, r = 0;
        long result = 0L;

        while (l < prices.Length)
        {
            r = l + 1;
            while (r < prices.Length &&
                prices[r - 1] - prices[r] == 1)
            {
                r++;
            }

            result += (r - l + 1L) * (r - l) / 2;
            l = r;
        }

        return result;
    }
}
// @lc code=end

