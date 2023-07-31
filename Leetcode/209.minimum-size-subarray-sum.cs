/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum = 0,
            min = int.MaxValue,
            l = 0, r = 0;

        while (r < nums.Length)
        {
            while (r < nums.Length && sum < target)
            {
                sum += nums[r++];
            }

            if (sum < target)
            {
                break;
            }

            while (l < r && sum >= target)
            {
                sum -= nums[l++];
            }

            min = Math.Min(min, r - l + 1);
        }

        return min == int.MaxValue ? 0 : min;
    }
}
// @lc code=end

