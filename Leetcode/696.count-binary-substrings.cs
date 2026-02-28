/*
 * @lc app=leetcode id=696 lang=csharp
 *
 * [696] Count Binary Substrings
 */

// @lc code=start
public class Solution {
    public int CountBinarySubstrings(string s) {
        int prev = 0, curr = 1,
            result = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                curr++;
            }
            else
            {
                result += Math.Min(prev, curr);
                prev = curr;
                curr = 1;
            }
        }

        result += Math.Min(prev, curr);
        return result;
    }
}
// @lc code=end

