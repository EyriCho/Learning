/*
 * @lc app=leetcode id=713 lang=csharp
 *
 * [713] Subarray Product Less Than K
 */

// @lc code=start
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        int l = 0,
            r = 0,
            result = 0;

        long product = 1L;
        
        while (r < nums.Length)
        {
            product *= nums[r];
            while (l <= r && product >= k)
            {
                product /= nums[l++];
            }
            result += r - l + 1;
            r++;
        }

        return result;
    }
}
// @lc code=end

