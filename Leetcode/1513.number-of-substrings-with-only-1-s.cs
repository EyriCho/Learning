/*
 * @lc app=leetcode id=1513 lang=csharp
 *
 * [1513] Number of Substrings With Only 1s
 */

// @lc code=start
public class Solution {
    public int NumSub(string s) {
        int i = 0, l = 0, len = 0;
        long result = 0L;

        while (i < s.Length)
        {
            if (s[i] == '0')
            {
                i++;
                continue;
            }

            l = i;
            while (i < s.Length && s[i] == '1')
            {
                i++;
            }

            len = i - l;
            result = (result + (long)(len + 1) * len / 2) % 1_000_000_007L;
        }

        return (int)result;
    }
}
// @lc code=end

