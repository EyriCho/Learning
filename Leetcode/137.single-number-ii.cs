/*
 * @lc app=leetcode id=137 lang=csharp
 *
 * [137] Single Number II
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        int c1 = 0, c2 = 0,
            mask;

        foreach (var num in nums)
        {
            c2 ^= c1 & num;
            c1 ^= num;
            mask = ~(c1 & c2);
            c1 &= mask;
            c2 &= mask;
        }

        return c1;
    }
}
// @lc code=end

