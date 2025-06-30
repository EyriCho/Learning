/*
 * @lc app=leetcode id=1061 lang=csharp
 *
 * [1061] Lexicographically Smallest Equivalent String
 */

// @lc code=start
public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        int[] groups = new int[26];
        for (int i = 0; i < 26; i++)
        {
            groups[i] = i;
        }

        int FindGroup(char c)
        {
            int idx = c - 'a';
            while (groups[idx] != idx)
            {
                idx = groups[idx];
            }
            return idx;
        }

        int g1 = 0, g2 = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            g1 = FindGroup(s1[i]);
            g2 = FindGroup(s2[i]);

            if (g1 < g2)
            {
                groups[g2] = g1;
            }
            else if (g2 < g1)
            {
                groups[g1] = g2;
            }
        }

        char[] array = new char[baseStr.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)('a' + FindGroup(baseStr[i]));
        }

        return new string(array);
    }
}
// @lc code=end

