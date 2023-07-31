/*
 * @lc app=leetcode id=664 lang=csharp
 *
 * [664] Strange Printer
 */

// @lc code=start
public class Solution {
    public int StrangePrinter(string s) {
        var dp = new int[s.Length, s.Length];
        for (int l = s.Length - 1; l >= 0; l--)
        {
            dp[l, l] = 1;
            for (int r = l + 1; r < s.Length; r++)
            {
                if (s[l] == s[r])
                {
                    dp[l, r] = dp[l + 1, r];
                }
                else
                {
                    dp[l, r] = int.MaxValue;
                    for (int k = l; k < r; k++)
                    {
                        dp[l, r] = Math.Min(dp[l, r], dp[l, k] + dp[k + 1, r]);
                    }
                }
            }
        }

        return dp[0, s.Length - 1];
    }
}
// @lc code=end

