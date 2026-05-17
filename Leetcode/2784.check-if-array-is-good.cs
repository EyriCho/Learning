/*
 * @lc app=leetcode id=2784 lang=csharp
 *
 * [2784] Check if Array is Good
 */

// @lc code=start
public class Solution {
    public bool IsGood(int[] nums) {
        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= 1; i--)
        {
            if (nums[i - 1] != i)
            {
                return false;
            }
        }

        return nums[^1] == nums.Length - 1;
    }
}
// @lc code=end

