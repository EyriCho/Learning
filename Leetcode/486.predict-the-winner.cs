/*
 * @lc app=leetcode id=486 lang=csharp
 *
 * [486] Predict the Winner
 */

// @lc code=start
public class Solution {
    public bool PredictTheWinner(int[] nums) {
        if (nums.Length == 1)
        {
            return true;
        }

        var dp = new int[nums.Length, nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i, i] = nums[i];
        }
        
        for (int l = nums.Length - 1; l >= 0; l--)
        {
            for (int r = l + 1; r < nums.Length; r++)
            {
                dp[l, r] = Math.Max(
                    nums[l] - dp[l + 1, r],
                    nums[r] - dp[l, r - 1]
                );
            }
        }

        return dp[0, nums.Length - 1] >= 0;
    }
}
// @lc code=end

