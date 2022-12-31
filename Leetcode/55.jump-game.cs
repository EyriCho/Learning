/*
 * @lc app=leetcode id=55 lang=csharp
 *
 * [55] Jump Game
 */

// @lc code=start
public class Solution {
    public bool CanJump(int[] nums) {
        int i = 0,
            reach = 0;
        
        for (; i <= reach && i < nums.Length; i++)
        {
            reach = Math.Max(reach, i + nums[i]);
        }
        
        return i == nums.Length;
    }
}
// @lc code=end

