/*
 * @lc app=leetcode id=650 lang=csharp
 *
 * [650] 2 Keys Keyboard
 */

// @lc code=start
public class Solution {
    public int MinSteps(int n) {
        if (n == 1)
        {
            return 0;
        }

        int divisor = n;
        for (int i = n - 1; i > 1; i--)
        {
            if (n % i == 0)
            {
                divisor = i;
                break;
            }
        }

        if (divisor == n)
        {
            return n;
        }

        return n / divisor + MinSteps(divisor);        
    }
}
// @lc code=end

