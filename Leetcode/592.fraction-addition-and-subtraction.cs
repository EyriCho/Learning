/*
 * @lc app=leetcode id=592 lang=csharp
 *
 * [592] Fraction Addition and Subtraction
 */

// @lc code=start
public class Solution {
    public string FractionAddition(string expression) {
        int numerator = 0,
            denominator = 1,
            num = 1,
            deno = 1,
            sign = 0,
            common = 0,
            i = 0;

        int GCD(int m, int n)
        {
            int temp = 0;
            while (n != 0)
            {
                temp = m % n;
                m = n;
                n = temp;
            }
            return m;
        }

        while (i < expression.Length)
        {
            num = 0;
            deno = 0;
            sign = 1;
            if (expression[i] == '-')
            {
                sign = -1;
                i++;
            }
            else if (expression[i] == '+')
            {
                i++;
            }

            while (expression[i] != '/')
            {
                num = num * 10 + (expression[i++] - '0');
            }

            i++;
            while (i < expression.Length &&
                expression[i] >= '0' &&
                expression[i] <= '9')
            {
                deno = deno * 10 + (expression[i++] - '0');
            }

            numerator = numerator * deno + num * sign * denominator;
            denominator *= deno;

            common = GCD(Math.Abs(numerator), denominator);
            numerator /= common;
            denominator /= common;
        }

        return $"{numerator}/{denominator}";
    }
}
// @lc code=end

