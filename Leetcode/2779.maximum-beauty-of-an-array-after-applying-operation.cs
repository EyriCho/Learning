/*
 * @lc app=leetcode id=2779 lang=csharp
 *
 * [2779] Maximum Beauty of an Array After Applying Operation
 */

// @lc code=start
public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        Array.Sort(nums);

        int l = 0,
            r = 0,
            result = 0;
        
        while (r < nums.Length)
        {
            while (l < r && nums[l] + 2 * k < nums[r])
            {
                l++;
            }

            result = Math.Max(result, r - l + 1);

            r++;
        }

        return result;
    }
}
// @lc code=end

