/*
 * @lc app=leetcode id=2366 lang=csharp
 *
 * [2366] Minimum Replacements to Sort the Array
 */

// @lc code=start
public class Solution {
    public long MinimumReplacement(int[] nums) {
        var result = 0L;
        int prev = nums[nums.Length - 1];

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] > prev)
            {
                var operation = nums[i] / prev + (nums[i] % prev == 0 ? 0 : 1);
                result += operation - 1;
                prev = nums[i] / operation;
            }
            else
            {
                prev = nums[i];
            }
        }
        return result;
    }
}
// @lc code=end

