/*
 * @lc app=leetcode id=3573 lang=csharp
 *
 * [3573] Best Time to Buy and Sell Stock V
 */

// @lc code=start
public class Solution {
    public long MaximumProfit(int[] prices, int k) {
        long[,] dp = new long[k + 1, 3];
        for (int t = 1; t <= k; t++)
        {
            dp[t, 1] = -prices[0];
            dp[t, 2] = prices[0];
        }

        for (int i = 1; i < prices.Length; i++)
        {
            for (int t = k; t > 0; t--)
            {
                dp[t, 0] = Math.Max(dp[t, 0],
                    Math.Max(dp[t , 1] + prices[i],
                        dp[t, 2] - prices[i]));

                dp[t, 1] = Math.Max(dp[t, 1],
                    dp[t - 1, 0] - prices[i]);

                dp[t, 2] = Math.Max(dp[t, 2],
                    dp[t - 1, 0] + prices[i]);
            }
        }

        return dp[k, 0];
    }
}
// @lc code=end

