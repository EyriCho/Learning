/*
 * @lc app=leetcode id=81 lang=csharp
 *
 * [81] Search in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums.Length == 0)
            return false;
            
        int l = 0, r = nums.Length - 1;
        
        while ((nums[l] <= target || nums[r] >= target) && l <= r)
        {
            if (nums[l] == target || nums[r] == target)
                return true;
            else if (l == r)
                return false;
            l++;
            r--;
        }
        return false;
    }
}
// @lc code=end

