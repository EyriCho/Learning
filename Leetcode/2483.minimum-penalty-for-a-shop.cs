/*
 * @lc app=leetcode id=2483 lang=csharp
 *
 * [2483] Minimum Penalty for a Shop
 */

// @lc code=start
public class Solution {
    public int BestClosingTime(string customers) {
        int profit = 0,
            hour = 0,
            maxProfit = 0;
        
        for (int i = 0; i < customers.Length; i++)
        {
            profit += customers[i] == 'Y' ? 1 : -1;

            if (profit > maxProfit)
            {
                maxProfit = profit;
                hour = i + 1;
            }
        }

        return hour;
    }
}
// @lc code=end

