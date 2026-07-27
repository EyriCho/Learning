/*
 * @lc app=leetcode id=3754 lang=csharp
 *
 * [3754] Concatenate Non-Zero Digits and Multiply by Sum I
 */

// @lc code=start
public class Solution {
    public long SumAndMultiply(int n) {
        int sum = 0,
            num = n,
            digit = 0,
            decimalPoint = 1,
            x = 0;
        
        while (num > 0)
        {
            digit = num % 10;
            sum += digit;
            num /= 10;
            if (digit > 0)
            {
                x += decimalPoint * digit;
                decimalPoint *= 10;
            }
        }

        return 1L * sum * x;
    }
}
// @lc code=end

