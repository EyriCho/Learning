/*
 * @lc app=leetcode id=1061 lang=csharp
 *
 * [1061] Lexicographically Smallest Equivalent String
 */

// @lc code=start
public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        var group = new int[26];
        for (int i = 0; i < 26; i++)
        {
            group[i] = i;
        }

        int findGroup(int i)
        {
            while (group[i] != i)
            {
                i = group[i];
            }

            return i;
        }

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                int g1 = findGroup(s1[i] - 'a');
                int g2 = findGroup(s2[i] - 'a');

                if (g1 < g2)
                {
                    group[g2] = g1;
                }
                else if (g1 > g2)
                {
                    group[g1] = g2;
                }
            }
        }

        var array = new char[baseStr.Length];
        for (int i = 0; i < baseStr.Length; i++)
        {
            array[i] = (char)(findGroup(baseStr[i] - 'a') + 'a');
        }

        return new string(array);
    }
}
// @lc code=end

