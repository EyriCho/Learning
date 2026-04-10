/*
 * @lc app=leetcode id=3418 lang=csharp
 *
 * [3418] Maximum Amount of Money Robot Can Earn
 */

// @lc code=start
public class Solution {
    public int MaximumAmount(int[][] coins) {
        int[,] dp = new int[coins[0].Length + 1, 3];
        for (int i = 0; i <= coins[0].Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dp[i, j] = int.MinValue / 2; 
            }
        }
        dp[1, 0] = dp[1, 1] = dp[1, 2] = 0;

        int c = 0;
        foreach (int[] row in coins)
        {
            for (int j = 1; j <= row.Length; j++)
            {
                c = row[j - 1];
                dp[j, 2] = Math.Max(Math.Max(dp[j - 1, 2], dp[j, 2]) + c,
                    Math.Max(dp[j - 1, 1], dp[j, 1]));
                dp[j, 1] = Math.Max(Math.Max(dp[j - 1, 1], dp[j, 1]) + c,
                    Math.Max(dp[j - 1, 0], dp[j, 0]));
                dp[j, 0] = Math.Max(dp[j - 1, 0], dp[j, 0]) + c;
            }
        }


        return dp[coins[0].Length, 2];
    }
}
// @lc code=end

