/*
 * @lc app=leetcode id=1920 lang=csharp
 *
 * [1920] Build Array from Permutation
 */

// @lc code=start
public class Solution {
    public int[] BuildArray(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] += (nums[nums[i]] & 1023) << 11;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] >>= 11;
        }

        return nums;
    }
}
// @lc code=end

