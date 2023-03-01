/*
 * @lc app=leetcode id=540 lang=csharp
 *
 * [540] Single Element in a Sorted Array
 */

// @lc code=start
public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            var m = (l + r) >> 1;
            if (m % 2 == 1)
            {
                m--;
            }
            if (nums[m] == nums[m + 1])
            {
                l = m + 2;
            }
            else
            {
                r = m;
            }
        }
        return nums[l];
    }
}
// @lc code=end

