/*
 * @lc app=leetcode id=446 lang=csharp
 *
 * [446] Arithmetic Slices II - Subsequence
 */

// @lc code=start
public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        var result = 0;
        
        var dp = new Dictionary<long, int>[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = new Dictionary<long, int>();
            for (int j = 0; j < i; j++)
            {
                var diff = (long)nums[i] - nums[j];
                if (!dp[i].ContainsKey(diff))
                    dp[i][diff] = 0;
                
                if (dp[j].ContainsKey(diff))
                {
                    result += dp[j][diff];
                    dp[i][diff] += dp[j][diff];
                }
                
                dp[i][diff]++;
            }
        }
        
        return result;
    }
}
// @lc code=end

