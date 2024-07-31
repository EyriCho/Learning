/*
 * @lc app=leetcode id=1509 lang=csharp
 *
 * [1509] Minimum Difference Between Largest and Smallest Value in Three Moves
 */

// @lc code=start
public class Solution {
    public int MinDifference(int[] nums) {
        if (nums.Length < 5)
        {
            return 0;
        }

        Array.Sort(nums);

        int diff = Math.Min(nums[^1] - nums[3], nums[^2] - nums[2]);
        diff = Math.Min(diff, nums[^3] - nums[1]);
        diff = Math.Min(diff, nums[^4] - nums[0]);

        return diff;
    }
}
// @lc code=end

