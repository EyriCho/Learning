/*
 * @lc app=leetcode id=162 lang=csharp
 *
 * [162] Find Peak Element
 */

// @lc code=start
public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            var m = (l + r) / 2;
            if (nums[m] < nums[m + 1])
                l = m + 1;
            else
                r = m;
        }
        return r;
    }
}
// @lc code=end

