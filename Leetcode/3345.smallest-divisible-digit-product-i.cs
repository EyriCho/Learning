/*
 * @lc app=leetcode id=3345 lang=csharp
 *
 * [3345] Smallest Divisible Digit Product I
 */

// @lc code=start
public class Solution {
    public int SmallestNumber(int n, int t) {
        if (t == 1)
        {
            return n;
        }

        int num = 0,
            d = 0,
            product = 0;
        for (int i = n; i <= 101; i++)
        {
            num = i;
            product = 1;
            while (num > 0)
            {
                product *= num % 10;
                num /= 10;
            }
            if (product % t == 0)
            {
                return i;
            }
        }

        return 1;
    }
}
// @lc code=end

