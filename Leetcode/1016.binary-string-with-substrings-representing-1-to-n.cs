/*
 * @lc app=leetcode id=1016 lang=csharp
 *
 * [1016] Binary String With Substrings Representing 1 To N
 */

// @lc code=start
public class Solution {
    public bool QueryString(string s, int n) {
        for (int i = 1; i <= n; i++)
        {
            var b = Convert.ToString(i, 2);
            if (!s.Contains(b))
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

