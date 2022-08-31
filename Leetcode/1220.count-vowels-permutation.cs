/*
 * @lc app=leetcode id=1220 lang=csharp
 *
 * [1220] Count Vowels Permutation
 */

// @lc code=start
public class Solution {
    public int CountVowelPermutation(int n) {
        const int mod = 1_000_000_007;
        
        var dp = new long[5] { 1L, 1L, 1L, 1L, 1L };
        var temp = new long[5];
        
        for (int c = 1; c < n; c++)
        {
            temp[0] = (dp[1] + dp[2] + dp[4]) % mod;
            temp[1] = (dp[0] + dp[2]) % mod;
            temp[2] = (dp[1] + dp[3]) % mod;
            temp[3] = dp[2];
            temp[4] = (dp[2] + dp[3]) % mod;
            Array.Copy(temp, dp, 5);
        }
        
        long result = 0L;
        for (int i = 0; i < 5; i++)
        {
            result = (result + dp[i]) % mod;
        }
        
        return (int)result;
    }
}
// @lc code=end

