/*
 * @lc app=leetcode id=2185 lang=csharp
 *
 * [2185] Counting Words With a Given Prefix
 */

// @lc code=start
public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int result = 0,
            i = 0;
        foreach (string word in words)
        {
            if (word.Length < pref.Length)
            {
                continue;
            }

            i = 0;
            while (i < pref.Length && word[i] == pref[i])
            {
                i++;
            }

            if (i == pref.Length)
            {
                result++;
            }
        }
        return result;
    }
}
// @lc code=end

