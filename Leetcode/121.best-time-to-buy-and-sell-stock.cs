/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2) return 0;
        int min = prices[0], result = int.MinValue;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
                min = prices[i];
            if (prices[i] - min > result)
                result = prices[i] - min;
        }
        
        return result;
    }
}
// @lc code=end

