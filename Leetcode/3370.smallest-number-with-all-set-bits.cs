/*
 * @lc app=leetcode id=3370 lang=csharp
 *
 * [3370] Smallest Number With All Set Bits
 */

// @lc code=start
public class Solution {
    public int SmallestNumber(int n) {
        int mask = 1;
        while (mask <= n)
        {
            mask <<= 1;
        }

        return mask - 1;
    }
}
// @lc code=end

