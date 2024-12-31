/*
 * @lc app=leetcode id=494 lang=csharp
 *
 * [494] Target Sum
 */

// @lc code=start
public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        if ((sum + target) % 2 == 1 ||
            Math.Abs(target) > sum)
        {
            return 0;
        }

        int positiveTarget = (sum + target) >> 1;
        int[] dp = new int[positiveTarget + 1];
        dp[0] = 1;
        foreach (int num in nums)
        {
            for (int i = positiveTarget; i >= num; i--)
            {
                dp[i] += dp[i - num];
            }
        }

        return dp[positiveTarget];
    }
}
// @lc code=end

