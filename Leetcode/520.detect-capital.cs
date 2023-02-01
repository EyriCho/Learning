/*
 * @lc app=leetcode id=520 lang=csharp
 *
 * [520] Detect Capital
 */

// @lc code=start
public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length < 2)
        {
            return true;
        }

        bool isUpper = word[0] < 'a' && word[1] < 'a';

        for (int i = 1; i < word.Length; i++)
        {
            if ((word[i] < 'a') != isUpper)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

