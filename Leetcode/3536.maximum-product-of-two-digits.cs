/*
 * @lc app=leetcode id=3536 lang=csharp
 *
 * [3536] Maximum Product of Two Digits
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int n) {
        int[] digits = new int[10];
        while (n > 0)
        {
            digits[n % 10]++;
            n /= 10;
        }

        int max = -1;
        for (int i = 9; i >= 0; i--)
        {
            if (digits[i] == 0)
            {
                continue;
            }

            if (max == -1)
            {
                max = i;
                digits[i]--;
            }

            if (digits[i] > 0)
            {
                return max * i;
            }
        }

        return 0;
    }
}
// @lc code=end

