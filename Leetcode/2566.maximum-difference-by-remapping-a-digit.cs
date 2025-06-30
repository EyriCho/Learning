/*
 * @lc app=leetcode id=2566 lang=csharp
 *
 * [2566] Maximum Difference by Remapping a Digit
 */

// @lc code=start
public class Solution {
    public int MinMaxDifference(int num) {
        int pos = 1, d = 0,
            n = num,
            maxDigit = 9, minDigit = 0,
            max = 0, min = 0;
        while (n > 0)
        {
            minDigit = n % 10;
            if (minDigit != 9)
            {
                maxDigit = minDigit;
            }
            n /= 10;
            pos *= 10;
        }

        pos /= 10;

        n = num;
        while (pos > 0)
        {
            d = n / pos;
            max += (d == maxDigit ? 9 : d) * pos;
            min += (d == minDigit ? 0 : d) * pos;
            n -= d * pos;
            pos /= 10;
        }

        return max - min;
    }
}
// @lc code=end

