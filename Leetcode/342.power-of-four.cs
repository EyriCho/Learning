/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfFour(int num) {
        // Beware of the binary representation of power of two;
        return num > 0 &&
            (num & num - 1) == 0 &&
            num == (num & 0x55555555);        
    }
}
// @lc code=end

