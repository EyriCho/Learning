/*
 * @lc app=leetcode id=3151 lang=csharp
 *
 * [3151] Special Array I
 */

 // @lc code=start
 public class Solution {
    public bool IsArraySpecial(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            if ((nums[i] + nums[i - 1]) % 2 == 0)
            {
                return false;
            }
        }

        return true;
    }
 }
 // @lc code=end
 
 