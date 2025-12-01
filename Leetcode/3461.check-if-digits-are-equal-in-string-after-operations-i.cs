/*
 * @lc app=leetcode id=3461 lang=csharp
 *
 * [3461] Check If Digits Are Equal in String After Operations I
 */

// @lc code=start
public class Solution {
    public bool HasSameDigits(string s) {
        int[] digits = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            digits[i] = s[i] - '0';
        }

        for (int len = s.Length - 1; len > 1; len--)
        {
            for (int i = 0; i < len; i++)
            {
                digits[i] = (digits[i] + digits[i + 1]) % 10;
            }
        }

        return digits[0] == digits[1];
    }
}
// @lc code=end

