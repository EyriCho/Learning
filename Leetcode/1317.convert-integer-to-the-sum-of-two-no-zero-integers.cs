/*
 * @lc app=leetcode id=1317 lang=csharp
 *
 * [1317] Convert Integer to the Sum of Two No-Zero Integers
 */

// @lc code=start
public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        bool HasZero(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        for (int i = 1; i < n; i++)
        {
            if (HasZero(i) || HasZero(n - i))
            {
                continue;
            }

            return new int[] { i, n - i };
        }

        return new int[] { 1, 1 };
    }
}
// @lc code=end

