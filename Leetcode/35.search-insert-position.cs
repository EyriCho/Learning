/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length;
        
        while (l < r)
        {
            var m = (l + r) >> 1;
            if (nums[m] < target)
                l = m + 1;
            else
                r = m;
        }
        return l;
    }
}
// @lc code=end

