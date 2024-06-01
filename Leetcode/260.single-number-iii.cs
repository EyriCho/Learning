/*
 * @lc app=leetcode id=260 lang=csharp
 *
 * [260] Single Number III
 */

// @lc code=start
public class Solution {
    public int[] SingleNumber(int[] nums) {
        if (nums.Length == 2)
        {
            return nums;
        }

        int xor = 0;
        foreach (int num in nums)
        {
            xor ^= num;
        }

        xor &= -xor;
        int num1 = 0,
            num2 = 0;

        foreach (int num in nums)
        {
            if ((num & xor) == 0)
            {
                num1 ^= num;
            }
            else
            {
                num2 ^= num;
            }
        }

        return new int[] { num1, num2 };
    }
}
// @lc code=end

