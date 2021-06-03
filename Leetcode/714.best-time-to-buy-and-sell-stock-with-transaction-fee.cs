/*
 * @lc app=leetcode id=714 lang=csharp
 *
 * [714] Best Time to Buy and Sell Stock with Transaction Fee
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int sell = 0, buy = int.MinValue;
        foreach (var price in prices)
        {
            int preSell = sell;
            sell = Math.Max(sell, buy + price);
            buy = Math.Max(buy, preSell - price - fee);
        }
        
        return sell;
    }
}
// @lc code=end

