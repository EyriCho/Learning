/*
 * @lc app=leetcode id=718 lang=csharp
 *
 * [718] Maximum Length of Repeated Subarray
 */

// @lc code=start
public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        var dp = new int[nums1.Length + 1, nums2.Length + 1];
        var result = 0;
        
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    dp[i + 1, j + 1] = dp[i, j] + 1;
                    result = Math.Max(result, dp[i + 1, j + 1]);
                }
                else
                {
                    dp[i + 1, j + 1] = 0;
                }
            }
        }
        return result;
    }
}
// @lc code=end

