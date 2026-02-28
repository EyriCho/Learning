/*
 * @lc app=leetcode id=712 lang=csharp
 *
 * [712] Minimum ASCII Delete Sum for Two Strings
 */

// @lc code=start
public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int[,] dp = new int[s1.Length + 1, s2.Length + 1];

        for (int i1 = 0; i1 < s1.Length; i1++)
        {
            for (int i2 = 0; i2 < s2.Length; i2++)
            {
                if (s1[i1] == s2[i2])
                {
                    dp[i1 + 1, i2 + 1] = dp[i1, i2] + s1[i1];
                }
                else
                {
                    dp[i1 + 1, i2 + 1] = Math.Max(dp[i1 + 1, i2], dp[i1, i2 + 1]);
                }
            }
        }

        int total = 0;
        foreach (char c in s1)
        {
            total += c;
        }
        foreach (char c in s2)
        {
            total += c;
        }

        return total - dp[s1.Length, s2.Length] * 2;
    }
}
// @lc code=end

