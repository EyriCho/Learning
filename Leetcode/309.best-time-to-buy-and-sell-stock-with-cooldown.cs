/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int preSell = 0, sell = 0,
            preBuy = 0, buy = int.MinValue;
        
        foreach (var price in prices)
        {
            preBuy = buy;
            buy = Math.Max(buy, preSell - price);
            preSell = sell;
            sell = Math.Max(sell, preBuy + price);
        }
        
        return sell;
    }
}
// @lc code=end

