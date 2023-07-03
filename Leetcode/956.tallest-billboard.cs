/*
 * @lc app=leetcode id=956 lang=csharp
 *
 * [956] Tallest Billboard
 */

// @lc code=start
public class Solution {
    public int TallestBillboard(int[] rods) {
        var dp = new int[rods.Length + 1, 5_001];
        for (int j = 1; j <= 5_000; j++)
        {
            dp[0, j] = -1_000_000_000;
        }

        for (int i = 1; i <= rods.Length; i++)
        {
            for (int j = 0; j <= 5_000; j++)
            {
                dp[i, j] = dp[i - 1, j];
                if (j >= rods[i - 1])
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - rods[i - 1]] + rods[i - 1]);
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - 1, rods[i - 1] - j] + j);
                }

                if (j + rods[i - 1] <= 5000)
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j + rods[i - 1]]);
                }
            }
        }

        return dp[rods.Length, 0];
    }
}
// @lc code=end

