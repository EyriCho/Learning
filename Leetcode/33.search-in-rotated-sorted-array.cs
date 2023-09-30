/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1,
            m = 0;

        while (l <= r)
        {
            m = (l + r) >> 1;
            if (nums[m] == target)
            {
                return m;
            }

            if (nums[l] <= nums[m])
            {
                if (nums[l] <= target && target < nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
            {
                if (nums[m] < target && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }

        return -1;
    }
}
// @lc code=end

