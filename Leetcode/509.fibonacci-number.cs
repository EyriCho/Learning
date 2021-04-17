/*
 * @lc app=leetcode id=509 lang=csharp
 *
 * [509] Fibonacci Number
 */

// @lc code=start
public class Solution {
    public int Fib(int n) {
        if (n < 2)
            return n;
        int p = 0, q = 1, r = 1;
        while (n-- > 1)
        {
            r = p + q;
            p = q;
            q = r;
        }
        
        return r;
    }
}
// @lc code=end

