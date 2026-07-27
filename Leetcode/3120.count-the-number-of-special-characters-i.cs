/*
 * @lc app=leetcode id=3120 lang=csharp
 *
 * [3120] Count the Number of Special Characters I
 */

// @lc code=start
public class Solution {
    public int NumberOfSpecialChars(string word) {
        int count = 0;
        bool[] upper = new bool[26],
            lower = new bool[26];
        foreach (char c in word)
        {
            if (c < 'a')
            {
                upper[c - 'A'] = true;
            }
            else
            {
                lower[c - 'a'] = true;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (upper[i] && lower[i])
            {
                count++;
            }
        }

        return count;
    }
}
// @lc code=end

