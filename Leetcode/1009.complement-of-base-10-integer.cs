/*
 * @lc app=leetcode id=1009 lang=csharp
 *
 * [1009] Complement of Base 10 Integer
 */

// @lc code=start
public class Solution {
    public int BitwiseComplement(int N) {
        if (N == 0)
            return 1;
        int temp = N;
        int total = 0;
        while (temp > 0)
        {
            total <<= 1;
            total++;
            temp /= 2;
        }
        return total - N;
    }
}
// @lc code=end

