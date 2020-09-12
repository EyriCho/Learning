/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        int buy = int.MinValue, sell = 0, preBuy = 0, preSell = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            preBuy = buy;
            if (preSell - prices[i] > preBuy)
                buy = preSell - prices[i];
            
            preSell = sell;
            if (preBuy + prices[i] > preSell)
                sell = preBuy + prices[i];
        }
        
        return sell;        
    }
}
// @lc code=end

