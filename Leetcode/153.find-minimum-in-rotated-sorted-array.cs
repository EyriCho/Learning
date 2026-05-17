/*
 * @lc app=leetcode id=153 lang=csharp
 *
 * [153] Find Minimum in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int l = 0,
            m = 0,
            r = nums.Length - 1;
        
        while (l < r)
        {
            m = (l + r) >> 1;
            if (nums[m] > nums[r])
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return nums[r];
    }
}
// @lc code=end

