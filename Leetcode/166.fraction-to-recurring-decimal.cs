/*
 * @lc app=leetcode id=166 lang=csharp
 *
 * [166] Fraction to Recurring Decimal
 */

// @lc code=start
public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0)
        {
            return "0";
        }

        StringBuilder sb = new ();
        if ((numerator < 0) ^ (denominator < 0))
        {
            sb.Append('-');
        }

        long dividend = Math.Abs((long)numerator),
            divisor = Math.Abs((long)denominator),
            remainder = dividend % divisor;
        
        sb.Append(dividend / divisor);
        if (remainder == 0L)
        {
            return sb.ToString();
        }

        sb.Append('.');
        Dictionary<long, int> remainderDict = new ();
        while (remainder > 0L)
        {
            if (remainderDict.TryGetValue(remainder, out int length))
            {
                sb.Insert(length, '(');
                sb.Append(')');
                return sb.ToString();
            }

            remainderDict[remainder] = sb.Length;
            remainder *= 10;
            sb.Append(remainder / divisor);
            remainder %= divisor;
        }
        
        return sb.ToString();
    }
}
// @lc code=end

