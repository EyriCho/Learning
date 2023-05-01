/*
 * @lc app=leetcode id=879 lang=csharp
 *
 * [879] Profitable Schemes
 */

// @lc code=start
public class Solution {
    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit) {
        var dp = new int[minProfit + 1, n + 1];
        for (int k = 0; k <= n; k++)
        {
            dp[0, k] = 1;
        }

        for (int i = 0; i < group.Length; i++)
        {
            for (int j = minProfit; j > -1; j--)
            {
                for (int k = n; k >= group[i]; k--)
                {
                    dp[j, k] = (
                            dp[j, k] +
                            dp[Math.Max(0, j - profit[i]), k - group[i]]
                        ) % 1_000_000_007;
                }
            }
        }

        return dp[minProfit, n];
    }
}
// @lc code=end

