/*
 * @lc app=leetcode id=2770 lang=csharp
 *
 * [2770] Maximum Number of Jumps to Reach the Last Index
 */

// @lc code=start
public class Solution {
    public int MaximumJumps(int[] nums, int target) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, -1);
        dp[0] = 0;

        for (int j = 1; j < nums.Length; j++)
        {
            for (int i = 0; i < j; i++)
            {
                if (dp[i] >= 0 &&
                    Math.Abs(nums[j] - nums[i]) <= target)
                {
                    dp[j] = Math.Max(dp[j], dp[i] + 1);
                }
            }
        }

        return dp[^1];
    }
}
// @lc code=end

