/*
 * @lc app=leetcode id=1910 lang=csharp
 *
 * [1910] Remove All Occurrences of a Substring
 */

// @lc code=start
public class Solution {
    public string RemoveOccurrences(string s, string part) {
        if (part.Length > s.Length)
        {
            return s;
        }

        int[] kmp = new int[part.Length];
        for (int i = 0, j = kmp[0] = -1; i < part.Length - 1;)
        {
            if (j == -1 || part[i] == part[j])
            {
                i++;
                j++;
                kmp[i] = part[i] != part[j] ? j : kmp[j];
            }
            else
            {
                j = kmp[j];
            }
        }

        int Locate()
        {
            for (int i = 0, j = 0; i < s.Length;)
            {
                if (j == -1 || s[i] == part[j]) {
                    i++;
                    j++;
                }
                else
                {
                    j = kmp[j];
                }

                if (j == part.Length)
                {
                    return i - j;
                }
            }
            
            return -1;
        }

        int pos = 0;
        while (true)
        {
            pos = Locate();
            if (pos == - 1)
            {
                break;
            }
            s = s[0..pos] + s[(pos + part.Length)..];
        }
        return s;
    }
}
// @lc code=end

