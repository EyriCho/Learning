/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }

        long temp = 0,
            copy = x;

        while (copy > 0)
        {
            temp = temp * 10 + copy % 10;
            copy /= 10;
        }

        return temp == x;
    }
}
// @lc code=end

