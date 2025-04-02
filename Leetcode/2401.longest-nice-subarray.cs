/*
 * @lc app=leetcode id=2401 lang=csharp
 *
 * [2401] Longest Nice Subarray
 */

// @lc code=start
public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int l = 0,
            r = 0,
            result = 0,
            mask = 0;
        
        while (r < nums.Length)
        {
            while ((nums[r] & mask) > 0)
            {
                mask ^= nums[l++];
            }

            mask |= nums[r++];
            result = Math.Max(result, r - l);
        }

        return result;
    }
}
// @lc code=end

