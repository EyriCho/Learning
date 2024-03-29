/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1, m = -1;
        
        while (l <= r)
        {
            m = (l + r) / 2;
            if (nums[m] == target)
            {
                return m;
            }
            else if (nums[m] < target)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }
        
        return -1;
    }
}
// @lc code=end

