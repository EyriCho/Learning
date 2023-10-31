/*
 * @lc app=leetcode id=1420 lang=csharp
 *
 * [1420] Build Array Where You Can Find The Maximum Exactly K Comparisons
 */

// @lc code=start
public class Solution {
    public int NumOfArrays(int n, int m, int k) {
        if (k > m)
        {
            return 0;
        }

        // 第i位，最大為j時，cost為k的結果；
        var dp = new long[n, m + 1, k + 1];
        for (int j = 1; j <= m; j++)
        {
            dp[0, j, 1] = 1L;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                int cost = Math.Min(j, k);
                for (int c = 1; c <= cost; c++)
                {
                    dp[i, j, c] = (dp[i, j, c] + dp[i - 1, j, c] * j) % 1_000_000_007;

                    for (int maxNum = 1; maxNum < j; maxNum++)
                    {
                        dp[i, j, c] = (dp[i, j, c] + dp[i - 1, maxNum, c - 1]) % 1_000_000_007;
                    }
                }
            }
        }

        var last = n - 1;
        var result = 0L;
        for (int j = k; j <= m; j++)
        {
            result = (result + dp[last, j, k]) % 1_000_000_007;
        }

        return (int)result;
    }
}
// @lc code=end

