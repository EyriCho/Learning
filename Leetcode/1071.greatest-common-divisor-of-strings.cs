/*
 * @lc app=leetcode id=1071 lang=csharp
 *
 * [1071] Greatest Common Divisor of Strings
 */

// @lc code=start
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int i = Math.Min(str1.Length, str2.Length);

        bool IsConcatenate(string target, string sub)
        {
            if (target.Length % sub.Length != 0)
            {
                return false;
            }

            int i = 0;
            while (i < target.Length)
            {
                int j = 0;
                while (j < sub.Length)
                {
                    if (target[i++] != sub[j++])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        while (i > 0)
        {
            if (IsConcatenate(str1, str1[0..i]) &&
                IsConcatenate(str2, str1[0..i]))
            {
                return str1[0..i];
            }
            i--;
        }

        return string.Empty;
    }
}
// @lc code=end

