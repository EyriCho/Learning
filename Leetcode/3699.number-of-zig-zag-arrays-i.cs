/*
 * @lc app=leetcode id=3699 lang=csharp
 *
 * [3699] Number of ZigZag Arrays I
 */

// @lc code=start
public class Solution {
    public int ZigZagArrays(int n, int l, int r) {
        int m = r - l + 1;
        int[] dp = new int[m];
        Array.Fill(dp, 1);

        int sum = 0,
            temp = 0,
            idx = 0,
            dir = 0;
        for (int i = 2; i <= n; i++)
        {
            sum = 0;
            if ((i & 1) == 0)
            {
                idx = 0;
                dir = 1;
            }
            else
            {
                idx = m - 1;
                dir = -1;
            }

            for (int j = 0; j < m; j++, idx += dir)
            {
                temp = dp[idx];
                dp[idx] = sum;
                sum = (sum + temp) % 1_000_000_007;
            }
        }
        
        int result = 0;
        for (int j = 0; j < m; j++)
        {
            result = (result + dp[j]) % 1_000_000_007;
        }

        return (result << 1) % 1_000_000_007;
    }
}
// @lc code=end

