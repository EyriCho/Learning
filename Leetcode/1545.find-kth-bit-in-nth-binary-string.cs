/*
 * @lc app=leetcode id=1545 lang=csharp
 *
 * [1545] Find Kth Bit in Nth Binary String
 */

// @lc code=start
public class Solution {
    public char FindKthBit(int n, int k) {
        if (n == 1)
        {
            return '0';
        }

        int len = (1 << n) - 1,
            m = len >> 1;
        return k switch
        {
            _ when k <= m => FindKthBit(n - 1, k),
            _ when k - 1 == m => '1',
            _ => FindKthBit(n - 1, len - k + 1) == '0' ? '1' : '0',
        };
    }
}
// @lc code=end

