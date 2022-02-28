/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var result = 0;
        
        for (int i = 0; i < accounts.Length; i++)
        {
            var total = accounts[i][0];
            
            for (int j = 1; j < accounts[i].Length; j++)
                total += accounts[i][j];
            
            result = Math.Max(result, total);
        }
        
        return result;
    }
}
// @lc code=end

