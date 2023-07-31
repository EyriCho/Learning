/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n) {
        double result = 1d;
        for (int i = n; i != 0; i /= 2, x *= x)
        {
            if (i % 2 != 0)
            {
                result *= x;
            }
        }
        return n < 0 ? (1d / result) : result;
    }
}
// @lc code=end

