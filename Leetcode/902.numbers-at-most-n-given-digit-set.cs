/*
 * @lc app=leetcode id=902 lang=csharp
 *
 * [902] Numbers At Most N Given Digit Set
 */

// @lc code=start
public class Solution {
    public int AtMostNGivenDigitSet(string[] digits, int n) {
        var str = n.ToString();
        int result = 0, pow = 1;
        for (int i = 1; i < str.Length; i++)
        {
            pow *= digits.Length;
            result += pow;
        }
        
        for (int i = 0; i < str.Length; i++)
        {
            bool same = false;
            foreach (var digit in digits)
            {
                if (digit[0] < str[i])
                    result += (int)Math.Pow(digits.Length, str.Length - 1 - i);
                else if (digit[0] == str[i])
                    same = true;
            }
            
            if (!same)
                return result;
        }
        
        return result + 1;
    }
}
// @lc code=end

