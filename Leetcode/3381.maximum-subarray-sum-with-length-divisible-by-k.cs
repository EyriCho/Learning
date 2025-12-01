/*
 * @lc app=leetcode id=3381 lang=csharp
 *
 * [3381] Maximum Subarray Sum With Length Divisible by K
 */

// @lc code=start
public class Solution {
    public long MaxSubarraySum(int[] nums, int k) {
        long sum = 0L,
            result = long.MinValue;
        long[] dp = new long[k];
        for (int i = 1; i < k; i++)
        {
            dp[i] = 1_000_000_000_000_000_000L;
        }
        dp[0] = 0;

        int left = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            left = i % k;
            sum += nums[i - 1];
            result = Math.Max(result, sum - dp[left]);
            dp[left] = Math.Min(dp[left], sum);
        }

        return result;
    }
}
// @lc code=end

