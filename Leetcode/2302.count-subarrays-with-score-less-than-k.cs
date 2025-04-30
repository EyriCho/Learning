/*
 * @lc app=leetcode id=2302 lang=csharp
 *
 * [2302] Count Subarrays With Score Less Than K
 */

// @lc code=start
public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        long result = 0,
            sum = 0;

        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            sum += nums[r];

            while (sum * (r - l + 1) >= k &&
                l <= r)
            {
                sum -= nums[l++];
            }

            result += r - l + 1;
        }

        return result;
    }
}
// @lc code=end

