/*
 * @lc app=leetcode id=689 lang=csharp
 *
 * [689] Maximum Sum of 3 Non-Overlapping Subarrays
 */

// @lc code=start
public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int[] sums = new int[nums.Length + 1];
        for (int i = 1; i <= nums.Length; i++)
        {
            sums[i] = sums[i - 1] + nums[i - 1];
        }

        int[,] dp = new int[nums.Length + 2, 4];
        for (int i = nums.Length - k + 1; i > 0; i--)
        {
            for (int j = 1; j < 4; j++)
            {
                dp[i, j] = Math.Max(dp[i + 1, j], dp[i + k, j - 1] + sums[i + k - 1] - sums[i - 1]);
            }
        }

        int[] result = new int[3];
        int x = 1, y = 3;
        while (y > 0)
        {
            while (dp[x, y] != dp[x + k, y - 1] + sums[x + k - 1] - sums[x - 1])
            {
                x++;
            }
            result[3 - y] = x - 1;
            x += k;
            y--;
        }
        
        return result;
    }
}
// @lc code=end

