/*
 * @lc app=leetcode id=2466 lang=csharp
 *
 * [2466] Count Ways To Build Good Strings
 */

// @lc code=start
public class Solution {
    public int CountGoodStrings(int low, int high, int zero, int one) {
        var dp = new long[high + 1];
        dp[0] = 1;

        var result = 0;
        for (int i = Math.Min(zero, one); i <= high; i++)
        {
            if (i >= zero)
            {
                dp[i] += dp[i - zero];
            }

            if (i >= one)
            {
                dp[i] += dp[i - one];
            }

            dp[i] %= 1_000_000_007;
        }

        for (int i = low; i <= high; i++)
        {
            result = (int)((result + dp[i]) % 1_000_000_007);
        }
        return result;
    }
}
// @lc code=end

