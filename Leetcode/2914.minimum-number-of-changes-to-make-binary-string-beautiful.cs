/*
 * @lc app=leetcode id=2914 lang=csharp
 *
 * [2914] Minimum Number of Changes to Make Binary String Beautiful
 */

// @lc code=start
public class Solution {
    public int MinChanges(string s) {
        int l = 0,
            r = 0,
            result = 0;

        while (l < s.Length)
        {
            r = l;
            while (r < s.Length &&
                s[r] == s[l])
            {
                r++;
            }

            if ((r - l) % 2 == 1)
            {
                result++;
                r++;
            }

            l = r;
        }

        return result;
    }
}
// @lc code=end

