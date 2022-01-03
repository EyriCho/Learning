/*
 * @lc app=leetcode id=476 lang=csharp
 *
 * [476] Number Complement
 */

// @lc code=start
public class Solution {
    public int FindComplement(int num) {
        int d = num;
        int i = 0;
        while (d > 0)
        {
            i++;
            d >>= 1;
        }
        
        return (~num & 2147483647) & ((1 << i) - 1);
    }
}
// @lc code=end

