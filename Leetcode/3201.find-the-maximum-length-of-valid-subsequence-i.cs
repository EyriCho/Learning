/*
 * @lc app=leetcode id=3201 lang=csharp
 *
 * [3201] Find the Maximum Length of Valid Subsequence I
 */

// @lc code=start
public class Solution {
    public int MaximumLength(int[] nums) {
        int xorZero = 0, xorOne = 0,
            andZero = 0, andOne = 0;
            
        foreach (int num in nums)
        {
            if ((num & 1) == 1)
            {
                andOne++;
                xorOne = Math.Max(xorOne, xorZero + 1);
            }
            else
            {
                andZero++;
                xorZero = Math.Max(xorZero, xorOne + 1);
            }
        }

        return Math.Max(Math.Max(xorZero, xorOne),
            Math.Max(andZero, andOne));
    }
}
// @lc code=end

