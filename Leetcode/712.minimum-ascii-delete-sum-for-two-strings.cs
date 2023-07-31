/*
 * @lc app=leetcode id=712 lang=csharp
 *
 * [712] Minimum ASCII Delete Sum for Two Strings
 */

// @lc code=start
public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        var dp = new int[s1.Length + 1, s2.Length + 1];

        for (int i1 = 1; i1 <= s1.Length; i1++)
        {
            for (int i2 = 1; i2 <= s2.Length; i2++)
            {
                if (s1[i1 - 1] == s2[i2 - 1])
                {
                    dp[i1, i2] = dp[i1 - 1, i2 - 1] + s1[i1 - 1];
                }
                else
                {
                    dp[i1, i2] = Math.Max(dp[i1 - 1, i2], dp[i1, i2 - 1]);
                }
            }
        }

        var sum = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            sum += s1[i];
        }
        for (int i = 0; i < s2.Length; i++)
        {
            sum += s2[i];
        }

        return sum - dp[s1.Length, s2.Length] * 2;
    }
}
// @lc code=end

