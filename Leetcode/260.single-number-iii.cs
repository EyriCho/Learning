/*
 * @lc app=leetcode id=260 lang=csharp
 *
 * [260] Single Number III
 */

// @lc code=start
public class Solution {
    public int[] SingleNumber(int[] nums) {
        var diff = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            diff ^= nums[i];
        }
        diff &= -diff;
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if ((diff & nums[i]) == 0)
                result[0] ^= nums[i];
            else
                result[1] ^= nums[i];            
        }
        return result;
    }
}
// @lc code=end

