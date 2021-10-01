/*
 * @lc app=leetcode id=115 lang=csharp
 *
 * [115] Distinct Subsequences
 */

// @lc code=start
public class Solution {
    public int NumDistinct(string s, string t) {
        var dp = new int[t.Length + 1, s.Length + 1];
        for (int j = 0; j <= s.Length; j++)
            dp[0, j] = 1;
        
        for (int i = 1; i <= t.Length; i++)
            for (int j = 1; j <= s.Length; j++)
                dp[i, j] = dp[i, j - 1] + (t[i - 1] == s[j - 1] ? dp[i - 1, j - 1] : 0);
        
        return dp[t.Length, s.Length];
    }
}
// @lc code=end

