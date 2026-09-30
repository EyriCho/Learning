/*
 * @lc app=leetcode id=3524 lang=csharp
 *
 * [3524] Find X Value of Array I
 */

// @lc code=start
public class Solution {
    public long[] ResultArray(int[] nums, int k) {
        long[] result = new long[k],
            dp = new long[k],
            ndp = new long[k];

        for (int i = 0; i < nums.Length; i++)
        {
            Array.Fill(ndp, 0L);
            ndp[nums[i] % k]++;

            for (int r = 0; r < k; r++)
            {
                ndp[(int)((long)r * nums[i] % k)] += dp[r];
            }

            for (int r = 0; r < k; r++)
            {
                result[r] += ndp[r];
            }

            (dp, ndp) = (ndp, dp);
        }

        return result;
    }
}
// @lc code=end

