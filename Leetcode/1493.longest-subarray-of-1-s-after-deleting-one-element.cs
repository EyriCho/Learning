/*
 * @lc app=leetcode id=1493 lang=csharp
 *
 * [1493] Longest Subarray of 1's After Deleting One Element
 */

// @lc code=start
public class Solution {
    public int LongestSubarray(int[] nums) {
        int l = 0,
            r = 0,
            zero = 0,
            result = 0;
        
        while (r < nums.Length)
        {
            zero += 1 - nums[r];

            while (zero > 1)
            {
                zero -= (1 - nums[l++]);
            }

            result = Math.Max(result, r - l);
            r++;
        }

        return result;
    }
}
// @lc code=end

