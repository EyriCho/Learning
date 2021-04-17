/*
 * @lc app=leetcode id=29 lang=csharp
 *
 * [29] Divide Two Integers
 */

// @lc code=start
public class Solution {
    public int Divide(int dividend, int divisor) {
        long divide(long d, long s)
        {
            if (d < s)
                return 0;

            long c = 1, sum = s, r = 0;
            while (d > (sum << 1))
            {
                sum <<= 1;
                c <<= 1;
            }
            r += c + divide(d - sum, s);
            return r;
        }
        
        long dend = Math.Abs((long)dividend),
            sor = Math.Abs((long)divisor);
        
        long result = divide(dend, sor);

        if ((dividend < 0) ^ (divisor < 0))
            result = -result;
        return result > int.MaxValue ? int.MaxValue : (int)result;
    }
}
// @lc code=end

