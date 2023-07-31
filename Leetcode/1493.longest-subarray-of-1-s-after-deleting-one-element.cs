/*
 * @lc app=leetcode id=1493 lang=csharp
 *
 * [1493] Longest Subarray of 1's After Deleting One Element
 */

// @lc code=start
public class Solution {
    public int LongestSubarray(int[] nums) {
        int prev = 0,
            curr = 0,
            result = 0;

        int i = 0;
        while (i < nums.Length)
        {
            curr = 0;
            while (i < nums.Length && nums[i] == 1)
            {
                curr++;
                i++;
            }

            result = Math.Max(result, curr + prev);
            prev = curr;
            i++;
        }

        if (curr == nums.Length)
        {
            return nums.Length - 1;
        }

        return result;
    }
}
// @lc code=end

