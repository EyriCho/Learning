/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if (k > prices.Length >> 1)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
        
        int[] buy = new int[k + 1],
            sell = new int[k + 1];
        Array.Fill(buy, int.MinValue);
        
        foreach (var price in prices)
        {
            for (int i = k; i > 0; i--)
            {
                sell[i] = Math.Max(sell[i], buy[i] + price);
                buy[i] = Math.Max(buy[i], sell[i - 1] - price);
            }
        }
        
        return sell[k];
    }
}
// @lc code=end

