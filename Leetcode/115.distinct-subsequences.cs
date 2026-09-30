/*
 * @lc app=leetcode id=115 lang=csharp
 *
 * [115] Distinct Subsequences
 */

// @lc code=start
public class Solution {
    public int NumDistinct(string s, string t) {
        if (t.Length > s.Length)
        {
            return 0;
        }

        int[] dp = new int[t.Length + 1];
        dp[0] = 1;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = t.Length - 1; j >= 0; j--)
            {
                if (s[i] == t[j])
                {
                    dp[j + 1] += dp[j];
                }
            }
        }

        return dp[t.Length];
    }
}
// @lc code=end

