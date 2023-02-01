/*
 * @lc app=leetcode id=918 lang=csharp
 *
 * [918] Maximum Sum Circular Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int max = nums[0],
            min = nums[0],
            currentMax = nums[0],
            currentMin = nums[0],
            total = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentMax = currentMax > 0 ? currentMax + nums[i] : nums[i];
            max = Math.Max(currentMax, max);
            currentMin = currentMin < 0 ? currentMin + nums[i] : nums[i];
            min = Math.Min(currentMin, min);
            total += nums[i];
        }

        return max < 0 ? max : Math.Max(max, total - min);
    }
}
// @lc code=end

