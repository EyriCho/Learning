/*
 * @lc app=leetcode id=198 lang=csharp
 *
 * [198] House Robber
 */

// @lc code=start
public class Solution {
    public int Rob(int[] nums) {
        int yesterday = 0, today = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            var temp = today;
            today = Math.Max(today, yesterday + nums[i]);
            yesterday = temp;
        }
        
        return today;
    }
}
// @lc code=end

