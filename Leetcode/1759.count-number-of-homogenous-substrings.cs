/*
 * @lc app=leetcode id=1759 lang=csharp
 *
 * [1759] Count Number of Homogenous Substrings
 */

// @lc code=start
public class Solution {
    public int CountHomogenous(string s) {
        int i = 0;
        long result = 0L;

        while (i < s.Length)
        {
            int r = i + 1;
            while (r < s.Length && s[r] == s[i])
            {
                r++;
            }

            result = (result + (long)(r - i) * (r - i + 1) / 2) % 1_000_000_007;
            i = r;
        }

        return (int)result;
    }
}
// @lc code=end

