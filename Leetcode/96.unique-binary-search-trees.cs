/*
 * @lc app=leetcode id=96 lang=csharp
 *
 * [96] Unique Binary Search Trees
 */

// @lc code=start
public class Solution {
    public int NumTrees(int n) {
        var dp = new int[n + 1];
        dp[0] = 1;
        
        for (int i = 1; i <= n; i++)
            for (int j = 1; j <= i; j++)
            {
                dp[i] += dp[j - 1] * dp[i - j];
            }
        
        return dp[n];
    }
}
// @lc code=end

