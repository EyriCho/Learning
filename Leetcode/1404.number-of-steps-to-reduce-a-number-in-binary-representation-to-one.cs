/*
 * @lc app=leetcode id=1404 lang=csharp
 *
 * [1404] Number of Steps to Reduce a Number in Binary Representation to One
 */

// @lc code=start
public class Solution {
    public int NumSteps(string s) {
        int result = s.Length - 1,
            carry = 0;
        for (int i = s.Length - 1; i > 0; i--)
        {
            if (s[i] - '0' + carry == 1)
            {
                result++;
                carry = 1;
            }
        }

        return result + carry;
    }
}
// @lc code=end

