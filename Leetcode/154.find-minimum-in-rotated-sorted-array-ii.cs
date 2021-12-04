/*
 * @lc app=leetcode id=154 lang=csharp
 *
 * [154] Find Minimum in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int l = 0,
            r = nums.Length - 1;
        
        while (l < r)
        {
            var m = (l + r) >> 1;
            
            if (nums[m] == nums[r])
                r--;
            else if (nums[m] > nums[r])
                l = m + 1;
            else
                r = m;
        }
        
        return nums[r];
    }
}
// @lc code=end

