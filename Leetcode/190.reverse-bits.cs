/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
public class Solution {
    public uint reverseBits(uint n) {
        int result = 0,
            i = 0;
        while (i++ < 32)
        {
            result = (result << 1) | (n & 1);
            n >>= 1;
        }

        return result;
    }
}
// @lc code=end

