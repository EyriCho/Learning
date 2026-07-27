/*
 * @lc app=leetcode id=3614 lang=csharp
 *
 * [3614] Process String with Special Operations II
 */

// @lc code=start
public class Solution {
    public char ProcessStr(string s, long k) {
        long length = 0L;
        foreach (char c in s)
        {
            if (c == '*')
            {
                if (length > 0)
                {
                    length--;
                }
            }
            else if (c == '#')
            {
                length <<= 1;
            }
            else if (c == '%')
            {
                continue;
            }
            else
            {
                length++;
            }
        }

        if (length < k + 1)
        {
            return '.';
        }

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '*')
            {
                length++;
            }
            else if (s[i] == '#')
            {
                if (k + 1 > length / 2)
                {
                    k -= length / 2;
                }
                length = length / 2;
            }
            else if (s[i] == '%')
            {
                k = length - 1 - k;
            }
            else if (k + 1 == length)
            {
                return s[i];
            }
            else
            {
                length--;
            }
        }

        return '.';
    }
}
// @lc code=end

