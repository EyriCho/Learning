/*
 * @lc app=leetcode id=1137 lang=csharp
 *
 * [1137] N-th Tribonacci Number
 */

// @lc code=start
public class Solution {
    public int Tribonacci(int n) {
        if (n < 2)
        {
            return n;
        }
        else if (n == 2)
        {
            return 1;
        }
        else
        {
            int a = 0,
                b = 1,
                c = 1;

            while (n-- > 2)
            {
                var num = a + b + c;
                a = b;
                b = c;
                c = num;
            }
            return c;
        }
    }
}
// @lc code=end

