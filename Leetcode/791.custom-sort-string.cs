/*
 * @lc app=leetcode id=791 lang=csharp
 *
 * [791] Custom Sort String
 */

// @lc code=start
public class Solution {
    public string CustomSortString(string order, string s) {
        int[] charCount = new int[26];

        foreach (char c in s)
        {
            charCount[c - 'a']++;
        }

        int i = 0,
            index = 0;
        char[] array = new char[s.Length];
        foreach (char c in order)
        {
            index = c - 'a';
            if (charCount[index] > 0)
            {
                Array.Fill(array, c, i, charCount[index]);
                i += charCount[index];
                charCount[index] = 0;
            }
        }

        for (int j = 0; j < 26; j++)
        {
            if (charCount[j] > 0)
            {
                Array.Fill(array, (char)('a' + j), i, charCount[j]);
                i += charCount[j];
            }
        }

        return new string(array);
    }
}
// @lc code=end

