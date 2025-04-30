/*
 * @lc app=leetcode id=2873 lang=csharp
 *
 * [2873] Maximum Value of an Ordered Triplet I
 */

// @lc code=start
public class Solution {
    public long MaximumTripletValue(int[] nums) {
        int max = Math.Max(nums[0], nums[1]);
        long diff = Math.Max(0L, nums[0] - nums[1]),
            result = 0L;
        for (int i = 2; i < nums.Length; i++)
        {
            result = Math.Max(result, diff * nums[i]);
            diff = Math.Max(diff, max - nums[i]);
            max = Math.Max(max, nums[i]);
        }

        return result;
    }
}
// @lc code=end

