/*
 * @lc app=leetcode id=673 lang=csharp
 *
 * [673] Number of Longest Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        int max = 0;

        var dp = new (int, int)[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = (1, 1);

            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    if (dp[j].Item1 >= dp[i].Item1)
                    {
                        dp[i] = (dp[j].Item1 + 1, dp[j].Item2);
                    }
                    else if (dp[j].Item1 + 1 == dp[i].Item1)
                    {
                        dp[i].Item2 += dp[j].Item2;
                    }
                }
            }
            max = Math.Max(max, dp[i].Item1);
        }

        var result = 0;
        foreach (var (length, count) in dp)
        {
            if (length == max)
            {
                result += count;
            }
        }
        return result;
    }
}
// @lc code=end

