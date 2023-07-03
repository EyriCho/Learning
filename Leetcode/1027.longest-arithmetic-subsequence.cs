/*
 * @lc app=leetcode id=1027 lang=csharp
 *
 * [1027] Longest Arithmetic Subsequence
 */

// @lc code=start
public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        var dp = new int[nums.Length, 10_000];
        int result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int p = 0; p < i; p++)
            {
                var diff = nums[i] - nums[p] + 500;
                dp[i, diff] = dp[p, diff] + 1;
                
                result = Math.Max(dp[i, diff] + 1, result);
            }
        }

        return result;
    }
}
// @lc code=end

