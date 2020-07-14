/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        uint mask = 1u << 31;
        
        while (n > 0)
        {
            result += mask * (n % 2);
            mask >>= 1;
            n >>= 1;
        }
        return result;
        }
}
// @lc code=end

