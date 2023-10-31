/*
 * @lc app=leetcode id=1458 lang=csharp
 *
 * [1458] Max Dot Product of Two Subsequences
 */

// @lc code=start
public class Solution {
    public int MaxDotProduct(int[] nums1, int[] nums2) {
        var dp = new int[nums1.Length + 1, nums2.Length + 1];

        for (int i1 = 0; i1 < nums1.Length; i1++)
        {
            for (int i2 = 0; i2 < nums2.Length; i2++)
            {
                var max = int.MinValue;
                if (i1 == 0 && i2 == 0)
                {
                    max = nums1[i1] * nums2[i2];
                }
                else if (i1 == 0)
                {
                    max = Math.Max(dp[i1 + 1, i2], nums1[i1] * nums2[i2]);
                }
                else if (i2 == 0)
                {
                    max = Math.Max(dp[i1, i2 + 1], nums1[i1] * nums2[i2]);
                }
                else
                {
                    max = Math.Max(max, nums1[i1] * nums2[i2]);
                    max = Math.Max(max, dp[i1, i2] + nums1[i1] * nums2[i2]);
                    max = Math.Max(max, dp[i1, i2 + 1]);
                    max = Math.Max(max, dp[i1 + 1, i2]);
                    max = Math.Max(max, dp[i1, i2]);
                }
                dp[i1 + 1, i2 + 1] = max;
            }
        }

        return dp[nums1.Length, nums2.Length];
    }
}
// @lc code=end

