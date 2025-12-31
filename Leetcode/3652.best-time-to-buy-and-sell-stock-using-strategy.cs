/*
 * @lc app=leetcode id=3652 lang=csharp
 *
 * [3652] Best Time to Buy and Sell Stock using Strategy
 */

// @lc code=start
public class Solution {
    public long MaxProfit(int[] prices, int[] strategy, int k) {
        long sum = 0L,
            origin = 0L,
            changed = 0L,
            maxDiff = 0L;

        for (int i = 0; i < prices.Length; i++)
        {
            sum += prices[i] * strategy[i];
            origin += prices[i] * strategy[i];
            changed += prices[i];

            if (i >= k / 2)
            {
                changed -= prices[i - k / 2];
            }

            if (i >= k)
            {
                origin -= prices[i - k] * strategy[i - k];
            }

            if (i >= k - 1)
            {
                maxDiff = Math.Max(maxDiff, changed - origin);
            }
        }

        return sum + maxDiff;
    }
}
// @lc code=end

