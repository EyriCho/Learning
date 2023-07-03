/*
 * @lc app=leetcode id=1035 lang=csharp
 *
 * [1035] Uncrossed Lines
 */

// @lc code=start
public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        var dp = new int[nums1.Length + 1, nums2.Length + 1];

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                dp[i + 1, j + 1] =
                    nums1[i] == nums2[j] ?
                        dp[i, j] + 1 :
                        Math.Max(dp[i + 1, j], dp[i, j + 1]);
            }
        }

        return dp[nums1.Length, nums2.Length];
    }
}
// @lc code=end

