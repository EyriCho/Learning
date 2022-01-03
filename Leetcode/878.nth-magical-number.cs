/*
 * @lc app=leetcode id=878 lang=csharp
 *
 * [878] Nth Magical Number
 */

// @lc code=start
public class Solution {
    public int NthMagicalNumber(int n, int a, int b) {
        int bcd (int num1, int num2)
        {
            return num2 == 0 ? num1 : bcd(num2, num1 % num2);
        }
        
        int lcm = a * b / bcd(a, b), mod = 1_000_000_007;
        long len = lcm / a + lcm / b - 1;
        long count = n / len,
            left = n % len;
        double nearest = left / (1.0 / a + 1.0 / b);
        int remainIdx = (int)Math.Min(Math.Ceiling(nearest / a) * a , Math.Ceiling(nearest / b) * b);
        return (int)((lcm * count + remainIdx) % mod);
    }
}
// @lc code=end

