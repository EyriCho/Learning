/*
 * @lc app=leetcode id=389 lang=csharp
 *
 * [389] Find the Difference
 */

// @lc code=start
public class Solution {
    public char FindTheDifference(string s, string t) {
        int xor = 0;
        foreach (var c in s)
            xor ^= c;
        foreach (var c in t)
            xor ^= c;
        return (char)xor;
    }
}
// @lc code=end

