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
        for (int i = 1; i <= nums1.Length; i++)
            for (int j = 1; j <= nums2.Length; j++)
            {
                if (nums1[i - 1] == nums2[j - 1])
                {    
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                    result = Math.Max(result, dp[i, j]);
                }
                else
                    dp[i, j] = 0;
            }
        
        return result;
    }
}
// @lc code=end

