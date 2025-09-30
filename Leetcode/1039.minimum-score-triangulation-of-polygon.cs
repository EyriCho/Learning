/*
 * @lc app=leetcode id=1039 lang=csharp
 *
 * [1039] Minimum Score Triangulation of Polygon
 */

// @lc code=start
public class Solution {
    public int MinScoreTriangulation(int[] values) {
        int[,] dp = new int[values.Length, values.Length];

        for (int j = 2; j < values.Length; j++)
        {
            for (int i = j - 2; i >= 0; i--)
            {
                dp[i, j] = int.MaxValue;
                for (int k = i + 1; k < j; k++)
                {
                    dp[i, j] = Math.Min(dp[i, j],
                        dp[i, k] + dp[k, j] + values[i] * values[j] * values[k]);
                }
            }
        }

        return dp[0, values.Length - 1];
    }
}
// @lc code=end

