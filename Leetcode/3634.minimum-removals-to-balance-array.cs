/*
 * @lc app=leetcode id=3634 lang=csharp
 *
 * [3634] Minimum Removals to Balance Array
 */

// @lc code=start
public class Solution {
    public int MinRemoval(int[] nums, int k) {
        if (nums.Length == 1)
        {
            return 0;
        }
        
        Array.Sort(nums);
        int count = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (nums[r] > (long)nums[l] * k)
            {
                l++;
            }
            
            count = Math.Max(count, r - l + 1);
        }

        return nums.Length - count;
    }
}
// @lc code=end

