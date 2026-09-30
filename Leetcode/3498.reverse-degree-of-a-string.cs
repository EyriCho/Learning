/*
 * @lc app=leetcode id=3498 lang=csharp
 *
 * [3498] Reverse Degree of a String
 */

// @lc code=start
public class Solution {
    public int ReverseDegree(string s) {
        int result = 0;

        for (int i = 0; i < s.Length; i ++)
        {
            result += (i + 1) * ('z' - s[i] + 1);
        }

        return result;
    }
}
// @lc code=end

