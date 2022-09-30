/*
 * @lc app=leetcode id=1770 lang=csharp
 *
 * [1770] Maximum Score from Performing Multiplication Operations
 */

// @lc code=start
public class Solution {
    public int MaximumScore(int[] nums, int[] multipliers) {
        if (nums.Length < 2)
        {
            return nums[0] * multipliers[0];
        }
        
        var dp = new int[nums.Length];
        Array.Fill(dp, int.MinValue);
        dp[1] = nums[0] * multipliers[0];
        dp[0] = nums[nums.Length - 1] * multipliers[0];
        
        for (int i = 1; i < multipliers.Length; i++)
        {
            if (i + 1 < nums.Length)
            {
                dp[i + 1] = dp[i] + nums[i] * multipliers[i];
            }
            
            for (int l = i; l > 0; l--)
            {
                dp[l] = Math.Max(
                    dp[l - 1] + nums[l - 1] * multipliers[i],
                    dp[l] + nums[nums.Length + l - i - 1] * multipliers[i]);
            }
            
            dp[0] = dp[0] + nums[nums.Length - i - 1] * multipliers[i];
        }
        
        return dp.Max();
    }
}
// @lc code=end

