/*
 * @lc app=leetcode id=474 lang=csharp
 *
 * [474] Ones and Zeroes
 */

// @lc code=start
public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        var dp = new int[m + 1, n + 1];
        
        foreach (var str in strs)
        {
            int z = 0, o = 0;
            foreach (var c in str)
                _ = c == '0' ? z++ : o++;
            
            for (int i = m; i >= z; i--)
                for (int j = n; j >= o; j--)
                    dp[i, j] = Math.Max(dp[i, j], dp[i - z, j - o] + 1);
        }
        
        return dp[m, n];
    }
}
// @lc code=end

