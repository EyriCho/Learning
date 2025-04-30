/*
 * @lc app=leetcode id=1922 lang=csharp
 *
 * [1922] Count Good Numbers
 */

// @lc code=start
public class Solution {
    public int CountGoodNumbers(long n) {
        const long mod = 1_000_000_007L;
        
        long QuickPower(int num, long pow)
        {
            long rst = 1L,
                mul = num;
            while (pow > 0)
            {
                if (pow % 2 == 1)
                {
                    rst = rst * mul % mod;
                }
                mul = mul * mul % mod;
                pow >>= 1;
            }

            return rst;
        }

        return (int)(QuickPower(5, (n + 1) >> 1) * QuickPower(4, n >> 1) % mod);
    }
}
// @lc code=end

