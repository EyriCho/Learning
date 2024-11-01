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
        
        int count = (1 << n) - 1;
        int half = count >> 1;
        if (k - 1 == half)
        {
            return '1';
        }
        else if (k <= half)
        {
            return FindKthBit(n - 1, k);
        }
        else
        {
            return FindKthBit(n - 1, count - k + 1) == '0' ? '1' : '0';
        }
    }
}
// @lc code=end

