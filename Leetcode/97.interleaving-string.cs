/*
 * @lc app=leetcode id=97 lang=csharp
 *
 * [97] Interleaving String
 */

// @lc code=start
public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length)
        {
            return false;
        }
        
        var dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;
        for (int i1 = 0; i1 < s1.Length; i1++)
        {
            if (s1[i1] == s3[i1])
            {
                dp[i1 + 1, 0] = true;
            }
            else
            {
                break;
            }
        }
        
        for (int i2 = 0; i2 < s2.Length; i2++)
        {
            if (s2[i2] == s3[i2])
            {
                dp[0, i2 + 1] = true;
            }
            else
            {
                break;
            }
        }
        
        
        for (int i1 = 1; i1 <= s1.Length; i1++)
        {
            for (int i2 = 1; i2 <= s2.Length; i2++)
            {
                dp[i1, i2] = (dp[i1 - 1, i2] && s1[i1 - 1] == s3[i1 + i2 - 1]) ||
                    (dp[i1, i2 - 1] && s2[i2 - 1] == s3[i1 + i2 - 1]);
            }
        }
        
        return dp[s1.Length, s2.Length];
    }
}
// @lc code=end

