/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue, result = 0;
        foreach (var price in prices)
        {
            min = Math.Min(min, price);
            result = Math.Max(result, price - min);
        }
        
        return result;
    }
}
// @lc code=end

