/*
 * @lc app=leetcode id=1432 lang=csharp
 *
 * [1432] Max Difference You Can Get From Changing an Integer
 */

// @lc code=start
public class Solution {
    public int MaxDiff(int num) {
        int pos = 1, d = 0,
            n = num,
            firstDigit = 0,
            maxDigit = 9, minDigit = 0,
            max = 0, min = 0;
        while (n > 0)
        {
            firstDigit = n % 10;
            if (firstDigit != 1 && firstDigit != 0)
            {
                minDigit = n % 10;
            }
            if (firstDigit != 9)
            {
                maxDigit = firstDigit;
            }
            n /= 10;
            pos *= 10;
        }

        pos /= 10;
        int minReplace = 0;
        if (firstDigit == 1)
        {
            minReplace = 0;
        }
        else
        {
            minReplace = 1;
        }

        n = num;
        while (pos > 0)
        {
            d = n / pos;
            max += (d == maxDigit ? 9 : d) * pos;
            min += (d == minDigit ? minReplace : d) * pos;
            n -= d * pos;
            pos /= 10;
        }

        return max - min;
    }
}
// @lc code=end

