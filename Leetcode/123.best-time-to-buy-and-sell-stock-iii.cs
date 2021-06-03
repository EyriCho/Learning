/*
 * @lc app=leetcode id=123 lang=csharp
 *
 * [123] Best Time to Buy and Sell Stock III
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int firstSell = 0, firstBuy = int.MinValue;
        int secondSell = 0, secondBuy = int.MinValue;
        
        foreach (var price in prices)
        {
            secondSell = Math.Max(secondSell, secondBuy + price);
            secondBuy = Math.Max(secondBuy, firstSell - price);
            firstSell = Math.Max(firstSell, firstBuy + price);
            firstBuy = Math.Max(firstBuy, -price);
        }
        
        return secondSell;
    }
}
// @lc code=end

