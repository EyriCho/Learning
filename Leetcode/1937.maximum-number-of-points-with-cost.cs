/*
 * @lc app=leetcode id=1937 lang=csharp
 *
 * [1937] Maximum Number of Points with Cost
 */

// @lc code=start
public class Solution {
    public long MaxPoints(int[][] points) {
        long[] dp = new long[points[0].Length];
        int lastCol = points[0].Length - 1;

        for (int i = points.Length - 1; i >= 0; i--)
        {
            long[] l2r = new long[points[0].Length],
                r2l = new long[points[0].Length];
            l2r[0] = dp[0];
            r2l[lastCol] = dp[lastCol];
            for (int j = 1; j < points[0].Length; j++)
            {
                l2r[j] = Math.Max(l2r[j - 1] - 1, dp[j]);
                r2l[lastCol - j] = Math.Max(r2l[lastCol - j + 1] - 1, dp[lastCol - j]);
            }

            for (int j = 0; j < points[0].Length; j++)
            {
                dp[j] = Math.Max(l2r[j], r2l[j]) + points[i][j];
            }
        }

        long result = long.MinValue;
        for (int j = 0; j < points[0].Length; j++)
        {
            result = Math.Max(result, dp[j]);
        }
        return result;
    }
}
// @lc code=end

