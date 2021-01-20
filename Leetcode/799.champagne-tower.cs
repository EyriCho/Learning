/*
 * @lc app=leetcode id=799 lang=csharp
 *
 * [799] Champagne Tower
 */

// @lc code=start
public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[] dp = new double[101];
        dp[0] = poured;
        
        for (int i = 1; i <= query_row; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                var half = (dp[j] - 1d) / 2d;
                if (half < 0d)
                    half = 0d;
                dp[j] = half;
                dp[j + 1] += half;
            }
        }
        
        return dp[query_glass] > 1d ? 1d : dp[query_glass];
    }
}
// @lc code=end

