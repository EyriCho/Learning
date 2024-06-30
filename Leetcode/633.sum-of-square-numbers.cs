/*
 * @lc app=leetcode id=633 lang=csharp
 *
 * [633] Sum of Square Numbers
 */

// @lc code=start
public class Solution {
    public bool JudgeSquareSum(int c) {
        long a = 0,
            b = (long)Math.Sqrt(c),
            sum = 0;

        while (a <= b)
        {
            sum = a * a + b * b;

            if (sum == c)
            {
                return true;
            }
            else if (sum < c)
            {
                a++;
            }
            else
            {
                b--;
            }
        }

        return false;
    }
}
// @lc code=end

