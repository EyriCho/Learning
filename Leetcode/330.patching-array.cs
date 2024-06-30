/*
 * @lc app=leetcode id=330 lang=csharp
 *
 * [330] Patching Array
 */

// @lc code=start
public class Solution {
    public int MinPatches(int[] nums, int n) {
        long missing = 1L;
        int result = 0,
            i = 0;
         
        while (missing <= n)
        {
            if (i < nums.Length && nums[i] <= missing)
            {
                missing += nums[i++];
            }
            else
            {
                missing += missing;
                result++;
            }
        }
        
        return result;
    }
}
// @lc code=end

