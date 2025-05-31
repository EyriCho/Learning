/*
 * @lc app=leetcode id=3355 lang=csharp
 *
 * [3355] Zero Array Transformation I 
 */

// @lc code=start
public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int[] dp = new int[nums.Length + 1];
        foreach (int[] q in queries)
        {
            dp[q[0]]++;
            dp[q[1] + 1]--;
        }

        int current = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            current += dp[i];

            if (current < nums[i])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

