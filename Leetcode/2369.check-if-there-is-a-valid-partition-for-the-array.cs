/*
 * @lc app=leetcode id=2369 lang=csharp
 *
 * [2369] Check if There is a Valid Partition For The Array
 */

// @lc code=start
public class Solution {
    public bool ValidPartition(int[] nums) {
        var dp = new bool[nums.Length + 1];
        dp[0] = true;
        dp[2] = nums[1] == nums[0];
        
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] &&
                dp[i - 1])
            {
                dp[i + 1] = true;
            }
            else if (nums[i] == nums[i - 1] &&
                nums[i] == nums[i - 2] &&
                dp[i - 2])
            {
                dp[i + 1] = true;
            }
            else if (nums[i] == nums[i - 1] + 1 &&
                nums[i] == nums[i - 2] + 2 &&
                dp[i - 2])
            {
                dp[i + 1] = true;
            }
        }

        return dp[nums.Length];
    }
}
// @lc code=end

