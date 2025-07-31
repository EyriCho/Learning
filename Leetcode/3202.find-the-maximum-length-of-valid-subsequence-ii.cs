/*
 * @lc app=leetcode id=3202 lang=csharp
 *
 * [3202] Find the Maximum Length of Valid Subsequence II
 */

// @lc code=start
public class Solution {
    public int MaximumLength(int[] nums, int k) {
        int[] dp = new int[k];
        int left = 0,
            result = 2;
        for (int i = 0; i < k; i++)
        {
            Array.Fill(dp, 0);

            foreach (int num in nums)
            {
                left = num % k;
                dp[left] = Math.Max(dp[left], dp[(i + k - left) % k] + 1);

                result = Math.Max(result, dp[left]);
            }
        }

        return result;
    }
}
// @lc code=end

